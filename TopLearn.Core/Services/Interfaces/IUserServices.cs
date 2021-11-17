using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services.Interfaces
{
   public interface IUserServices
    {
        #region Register
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        #endregion
        #region ActiveAccount
        bool ActiveAccount(string activeCode);
        #endregion
        #region Login
        User LoginUser(LoginViewModel login);
        #endregion
        #region ForgotPassword 
        User GetUserByEmail(string email);
        #endregion
        #region ResetPassword 
        User GetUserByActiveCode(string activeCode);
        void UpdateUser(User user);
        #endregion
       

    }
}
