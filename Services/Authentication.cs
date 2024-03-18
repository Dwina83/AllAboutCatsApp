using AllAboutCatsApp.Contract;
using AllAboutCatsApp.ViewModels;
using AllAboutCatsApp.Views;
using MongoDB.Driver;
using MongoDB.Driver.Core.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.Services
{
    public class Authentication //: IAuthentication
    {
        private readonly IMongoCollection<Models.Users> _users;
        private readonly IAlert _alertService;

        public Authentication()
        {
            _users = Data.DB.UserCollection();
        }

        public async Task<bool> IsAuthenticatedAsync(string username, string password)
        {
            var user = await _users.Find(x => x.FullName == username).FirstOrDefaultAsync();
            if (user == null)
            {
                return false;
            }
            return Authentication.VerifyPassword(password, user.Password);
        }

        private static bool VerifyPassword(string inputPassword, string password)
        {
            if (inputPassword == password)
            {
                return true;
            }
            else
                return false;
        }

        //internal Task<bool> IsAuthenticatedAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
