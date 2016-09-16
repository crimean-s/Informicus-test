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
        private DbContext context;

        public EFUsersRepository ()
        {
            context = new DbContext(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        }

        // Users

        public IEnumerable<User> GetUsers ()
        {
            return context.Users;
        }

        public User GetUserById (int id)
        {
            return context.Users.FirstOrDefault(x => x.UserId == id);
        }

        // Groups

        public IEnumerable<Group> GetGroups()
        {
            return context.Groups;
        }

        public Group GetGroupById(int id)
        {
            return context.Groups.FirstOrDefault(x => x.GroupId == id);
        }
    }
}