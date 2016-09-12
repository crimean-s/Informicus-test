using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Informicus_test_project.Models
{
    public class Entities
    {
        public class User
        {
            [Key]
            public int UserId { get; set; }
            public string UserNickname { get; set; }
            public int GroupId { get; set; }
        }

        public class Group
        {
            [Key]
            public int GroupId { get; set; }
            public string GroupName { get; set; }

            public ICollection<User> Users { get; set; }
        }

        public class SiteContext : DbContext
        {
            public SiteContext() : base("name=SiteContext")
            {
                Database.SetInitializer<SiteContext>(new SiteContextInitializer());
            }

            public DbSet<User> Users { get; set; }
            public DbSet<Group> Groups { get; set; }
        }

        public class SiteContextInitializer : CreateDatabaseIfNotExists<SiteContext>
        {
            protected override void Seed(SiteContext db)
            {
                IList<User> users = new List<User>();

                users.Add(new User (){ UserNickname = "Bob", GroupId = 1 });
                users.Add(new User() { UserNickname = "Nick", GroupId = 3 });
                users.Add(new User() { UserNickname = "Mat", GroupId = 2 });
                users.Add(new User() { UserNickname = "Gaga", GroupId = 2 });
                users.Add(new User() { UserNickname = "Robson", GroupId = 2 });
                users.Add(new User() { UserNickname = "Miha", GroupId = 3 });

                foreach (User user in users)
                    db.Users.Add(user);

                IList<Group> groups = new List<Group>();

                groups.Add(new Group() { GroupName = "Admin" });
                groups.Add(new Group() { GroupName = "Editor" });
                groups.Add(new Group() { GroupName = "User" });

                foreach (Group group in groups)
                    db.Groups.Add(group);

                //db.SaveChanges();

                base.Seed(db);
            }
        }
    }
}