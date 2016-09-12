using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using System.Configuration;
using Domain.Entities;

namespace Informicus_test_project.Models
{
    public class EFUsersRepository
    {
        private EFDbContext context;

        public EFUsersRepository ()
        {
            context = new EFDbContext(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        }

        public IEnumerable<User> GetUsers ()
        {
            return context.Users;
        }

        public User GetUserById (int id)
        {
            return context.Users.FirstOrDefault(x => x.UserId == id);
        }
    }
}