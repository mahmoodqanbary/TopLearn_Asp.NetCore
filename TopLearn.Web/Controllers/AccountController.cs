using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generators;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserServices _userServices;
        private IViewRenderService _viewRender;
        public AccountController(IUserServices userServices, IViewRenderService viewRender)
        {
            _userServices = userServices;
            _viewRender = viewRender;
        }
        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [Route("Register")]
        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            if (_userServices.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نمی باشد");
                return View(register);      
            }
            if (_userServices.IsExistEmail(FixedText.FixedEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده معتبر نمی باشد");
            }

            User user = new User()
            {
                ActiveCode = NameGenerator.GeneratUniqCode(),
                UserName = register.UserName,
                Email = FixedText.FixedEmail(register.Email),
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                RegisterDate = DateTime.Now,
                IsActive = false,
                Avatar = "Defult.jpg",
               
            };
            _userServices.AddUser(user);
            #region Send Email 
            string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.SendEmail.Send(user.Email, "فعالسازی حساب کاربری", body);
            #endregion

            return View("SuccessRegister",user);
        }
        #endregion
        #region AcctiveAccount
        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userServices.ActiveAccount(id);
            return View();
        }
        #endregion
        #region Login
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("Login")]
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var user = _userServices.LoginUser(login);
            if(user !=null)
            {
                if (user.IsActive)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name, user.UserName)
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var properties = new AuthenticationProperties() 
                    {
                        IsPersistent = login.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);
                    ViewBag.IsSuccess = true;
                    
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد ");

                }
            }
           
            ModelState.AddModelError("Email", "کاربری با مشخصات وارد شده یافت نشد ");
            return View(login);
        }
        #endregion
        #region Logout
        [Route("/Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/login");
        }
        #endregion
        #region ForgotPassword
        [Route ("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [Route("ForgotPassword")]
        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
            {
                return View(forgot);
            }
            string fixedEmail = FixedText.FixedEmail(forgot.Email);
            User user = _userServices.GetUserByEmail(fixedEmail);
            if(user == null)
            {
                ViewBag.IsSuccess = false;
                return View(forgot);
            }
            var bodyEmail = _viewRender.RenderToStringAsync("_ForgotPassword", user);
            SendEmail.SendEmail.Send(user.Email, "بازیابی کلمه عبور", bodyEmail);
            ViewBag.IsSuccess = true;
            return View();
        }
        #endregion
        #region ResetPassword
        
        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel() 
            {
                ActiveCode = id
            });
        }
        
        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel reset)
        {
            if (!ModelState.IsValid)
            {
                return View(reset);
            }
            User user = _userServices.GetUserByActiveCode(reset.ActiveCode);
            if(user == null)
            {
                return NotFound();
            }
            string hashNewPassword = PasswordHelper.EncodePasswordMd5(reset.Password);
            user.Password = hashNewPassword;
            _userServices.UpdateUser(user);
            
            return Redirect("/Login");
        }

        #endregion


    }
}
