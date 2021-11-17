using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generators;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.User;
using TopLearn.Core.Services;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services
{
    public class UserPanelServices : IUserPanelServices
    {
        private TopLearnContext _context;
        public UserPanelServices(TopLearnContext context)
        {
            _context = context;
        }

        #region GetUserByUserName
        public User GetUserByUserName(string username)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username);
        }
        #endregion
        #region Get User Information
        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);
            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = GetUserWalletBalance(username);
            return information;
        }

        
        #endregion
        #region Get SideBar User Information
        public SideBarUserPanelViewModel GetSideBarUserInformation(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(u => new SideBarUserPanelViewModel()
            {
                UserName = u.UserName,
                RegisterDate = u.RegisterDate,
                ImageName = u.Avatar
            }).Single();

        }
        #endregion
        #region Edit User Profile 
        public EditProfileViewModel GetUserInformationForEditProfile(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(u => new EditProfileViewModel()
            {
                UserName = u.UserName,
                Email = u.Email,
                AvatarName = u.Avatar
            }).Single();
        }

        public void EditProfile(string username, EditProfileViewModel editProfile)
        {
           if(editProfile.UserAvatar != null)
            {
                string imagePath = "";
                if (editProfile.AvatarName != "Defult.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editProfile.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }

                }

                editProfile.AvatarName = NameGenerator.GeneratUniqCode() + Path.GetExtension(editProfile.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editProfile.AvatarName);
                using(var stream = new FileStream(imagePath, FileMode.Create))
                {
                    editProfile.UserAvatar.CopyTo(stream);
                }
            }

            var user = GetUserByUserName(username);
            user.UserName = editProfile.UserName;
            user.Email = editProfile.Email;
            user.Avatar = editProfile.AvatarName;

            UpdateUser(user);
            
        }

        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }


        #endregion

        #region ChangePassword
        public bool CompareOldPassword(string username, string oldPassword)
        {
            string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u => u.UserName == username && u.Password == hashOldPassword);
        }

        public void ChangeUserPassword(string username, string newPassword)
        {
            var user = GetUserByUserName(username);
            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            UpdateUser(user);
        }


        #endregion

        #region Wallet Services
        public int GetUserIdByUserName(string username)
        {
            return _context.Users.Single(u => u.UserName == username).UserId;
        }

        public int GetUserWalletBalance(string username)
        {
            int userId = GetUserIdByUserName(username);

            var deposit = _context.Wallets
                .Where(w => w.UserId == userId && w.TypeId == 1 && w.IsPay)
                .Select(w => w.Amount).ToList();

            var withdraw = _context.Wallets
                .Where(w => w.UserId == userId && w.TypeId == 2 && w.IsPay)
                .Select(w => w.Amount).ToList();

            return (deposit.Sum() - withdraw.Sum());
        }

        public List<WalletViewModel> GetUserWallet(string username)
        {
            int userId = GetUserIdByUserName(username);

            return _context.Wallets
                .Where(w => w.IsPay && w.UserId == userId)
                .Select(w => new WalletViewModel()
                {
                    Amount = w.Amount,
                    Description = w.Description,
                    DateTime = w.CreateDate,
                    Type = w.TypeId
                }).ToList();

        }

        public int ChargeWallet(string username, int amount, string description, bool isPay = false)
        {
            Wallet wallet = new Wallet()
            {
               Amount = amount,
               CreateDate = DateTime.Now,
               Description = description,
               IsPay = isPay,
               TypeId = 1,
               UserId = GetUserIdByUserName(username)
            };
          return  AddWallet(wallet);
        }

        public int AddWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet.WalletId;
        }

        public Wallet GetWalletByWalletId(int walletId)
        {
            return _context.Wallets.Find(walletId);
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }




        #endregion
    }
}
