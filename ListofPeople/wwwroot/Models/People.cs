using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace ListofPeople.wwwroot.Models
{
    public class People
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string Cities { get; set; }
    }
}
