using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services.Interfaces
{
   public interface IUserPanelServices
    {
        User GetUserByUserName(string username);
        InformationUserViewModel GetUserInformation(string username);
        SideBarUserPanelViewModel GetSideBarUserInformation(string username);
        EditProfileViewModel GetUserInformationForEditProfile(string username);
        void EditProfile(string username, EditProfileViewModel editProfile);
        void UpdateUser(User user);

        bool CompareOldPassword(string username, string oldPassword);
        void ChangeUserPassword(string username, string newPassword);

        #region Wallet Services
        int GetUserIdByUserName(string username);
        int GetUserWalletBalance(string username);
        List<WalletViewModel> GetUserWallet(string username);
        int ChargeWallet(string username, int amount, string description, bool isPay = false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);
        #endregion
    }



}
