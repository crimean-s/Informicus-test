using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain.Entities
{
    public class User : IdentityUser
    {
        [Key]
        public override string Id { get; set; }

        public override string UserName { get; set; }

        public string UserFirstname { get; set; }

        public string UserLastname { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int GroupId { get; set; }
    }
}
