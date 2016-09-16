using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
