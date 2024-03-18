using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCatsApp.ViewModels
{
    internal class UserSingletonViewModels
    {
        private readonly IMongoCollection<Models.Users> _users;

        private static readonly Lazy<UserSingletonViewModels> _lazy = new Lazy<UserSingletonViewModels>(() => new UserSingletonViewModels());

        public static UserSingletonViewModels Instance => _lazy.Value;

        public UserSingletonViewModels() 
        {
            _users = Data.DB.UserCollection();
        }

        public async Task InsertUserAsync(Models.Users users)
        { 
            await _users.InsertOneAsync(users);
        }

        internal Task InsertUserAsync(string text)
        {
            throw new NotImplementedException();
        }
    }
}
