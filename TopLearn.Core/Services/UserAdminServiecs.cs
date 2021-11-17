using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services
{
    public class UserAdminServiecs : IUserAdminServies
    {
       private TopLearnContext _context;
        public UserAdminServiecs(TopLearnContext context)
        {
            _context = context;
        }
        #region Get List of Users
        public UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.Users;

            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(e => e.Email.Contains(filterEmail));
            }
            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.UserName.Contains(filterUserName));
            }

            //Show Item In Page
            int take = 20;
            int skip = (pageId - 1) * take;

            UserForAdminViewModel listOfUser = new UserForAdminViewModel();
            listOfUser.CurrentPage = pageId;
            listOfUser.PageCount = result.Count() / take;
            listOfUser.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();

            return listOfUser;
        }
        #endregion
    }
}
