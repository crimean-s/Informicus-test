using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace Informicus_test_project.Models
{
    public class ApplicationUserStore : UserStore<User> 
    {
        public ApplicationUserStore(ApplicationDbContext context) : base(context)
        {
        }
    }
}