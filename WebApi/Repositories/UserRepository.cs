using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Contexts;
using WebApi.Entities;

namespace WebApi.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(): base(new WebApiContext())
        {
            DbContext.Configuration.ProxyCreationEnabled = false;
        }

        public User GetUserbyId(Int64 id)
        {
            User stringUser = new User();
            stringUser.UserId = id;
            stringUser.Name = "Marcos";
            stringUser.Login = "marcos";
            stringUser.Senha = "123456";

            return stringUser;

        } 

        public void SaveNewUser(User user)
        {
            Console.WriteLine(user);
        }

        internal void DeleteById(int id)
        {
            User user = new User();
            user.UserId = id;

            Console.WriteLine(user.UserId);
        }
    }
}