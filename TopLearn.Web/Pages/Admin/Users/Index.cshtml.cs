using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;


namespace TopLearn.Web.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        private IUserAdminServies _userAdminServies;
        public IndexModel(IUserAdminServies userAdminServies)
        {
            _userAdminServies = userAdminServies;
        }

        public UserForAdminViewModel UserForAdminViewModel { get; set; }
        public void OnGet(int pageId=1, string filterEmail ="", string filterUserName="")
        {
            UserForAdminViewModel = _userAdminServies.GetUsers(pageId, filterEmail, filterUserName);
        }
    }
}
