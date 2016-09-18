using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Domain.Entities;

namespace Domain
{
    public class DbContext : System.Data.Entity.DbContext 
    {
        public DbContext(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }

        // public EFDbContext() : base("PrimaryConnectionString") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }


        public class SiteContextInitializer : CreateDatabaseIfNotExists<DbContext>
        {
            protected override void Seed(DbContext db)
            {
                
                IList<User> users = new List<User>();

                users.Add(new User() { UserNickname = "Bob", GroupId = 1 });
                users.Add(new User() { UserNickname = "Nick", GroupId = 3 });
                users.Add(new User() { UserNickname = "Mat", GroupId = 2 });
                users.Add(new User() { UserNickname = "Gaga", GroupId = 2 });
                users.Add(new User() { UserNickname = "Robson", GroupId = 2 });
                users.Add(new User() { UserNickname = "Miha", GroupId = 3 });

                foreach (User user in users)
                    db.Users.Add(user);

                IList<Group> groups = new List<Group>();

                groups.Add(new Group() { GroupName = "Admin" });
                groups.Add(new Group() { GroupName = "Client" });
                groups.Add(new Group() { GroupName = "Expert" });

                foreach (Group group in groups)
                    db.Groups.Add(group);

                //db.SaveChanges();

                base.Seed(db);
            }
        }

    }
}
