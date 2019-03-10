using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace register.Models
{
    public class registermodels
    {   [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
