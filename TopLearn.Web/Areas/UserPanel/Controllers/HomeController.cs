
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private IUserPanelServices _userPanelService;
        public HomeController(IUserPanelServices userPanelServices)
        {
            _userPanelService = userPanelServices;
        }
        public IActionResult Index()
        {
            return View(_userPanelService.GetUserInformation(User.Identity.Name));
        }

        [Route("userpanel/editprofile")]
        public IActionResult EditProfile()
        {
            return View(_userPanelService.GetUserInformationForEditProfile(User.Identity.Name));
        }
        [Route("userpanel/editprofile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel editProfile)
        {
            if (!ModelState.IsValid)
            {
                return View(editProfile);
            }

            _userPanelService.EditProfile(User.Identity.Name, editProfile);

            //LOGOUT user 
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            ViewBag.EditProfile = true;
            return Redirect("/Login?EditProfile=true");
        }
        [Route("userPanel/ChangePassword")]
        public IActionResult ChanagePassword()
        {
            return View();
        }
        [Route("userPanel/ChangePassword")]
        [HttpPost]
        public IActionResult ChanagePassword(ChangePasswordViewModel changePassword)
        {
            if (!ModelState.IsValid)
            {
                return View(changePassword);
            }

            if(!_userPanelService.CompareOldPassword(User.Identity.Name, changePassword.OldPassword))
            {
                ModelState.AddModelError("OldPassword", "رمز عبور فعلی صحیح نمی باشد");
                return View(changePassword);
            }

            _userPanelService.ChangeUserPassword(User.Identity.Name, changePassword.Password);
            ViewBag.IsSuccess = true;

            return View();
        }
    }
}
