using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Domain.Entities;

namespace Informicus_test_project.Models.ViewModels
{
    public class UsersGroupViewModel
    {
        public IEnumerable<User>  Users { get; set; }
        public IEnumerable<Group> Groups { get; set; }
    }
}