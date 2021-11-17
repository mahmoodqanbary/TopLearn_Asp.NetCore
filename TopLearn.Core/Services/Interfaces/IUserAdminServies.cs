using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;

namespace TopLearn.Core.Services.Interfaces
{
   public interface IUserAdminServies
    {
        UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName ="");
    }
}
