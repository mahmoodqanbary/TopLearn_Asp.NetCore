using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;
using ZarinpalSandbox;

namespace TopLearn.Web.Areas.UserPanel.Controllers
{
    public class WalletController : Controller
    {
        private IUserPanelServices _userPanelServices;
        public WalletController(IUserPanelServices userPanelServices)
        {
            _userPanelServices = userPanelServices;
        }
        [Area("UserPanel")]
        [Authorize]
        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userPanelServices.GetUserWallet(User.Identity.Name);
            return View();
        }
        [Route("UserPanel/Wallet")]
        [HttpPost]
        public IActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userPanelServices.GetUserWallet(User.Identity.Name);
                return View(charge);

            }

            int walletId = _userPanelServices.ChargeWallet(User.Identity.Name, charge.Amount, "شارژ کیف پول");

            #region Online Payment

            var payment = new ZarinpalSandbox.Payment(charge.Amount);

            var res = payment.PaymentRequest("شارژ کیف پول", "https://localhost:44329/OnlinePayment/" + walletId);

            if (res.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }

            #endregion


            return null;
        }
    }
}
