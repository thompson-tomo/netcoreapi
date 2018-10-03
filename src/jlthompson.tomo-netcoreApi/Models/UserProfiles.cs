using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jlthompson.tomo_netcoreApi.Models
{
    public class UserProfiles
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName {get; set;}
        public string LastName{get; set;}
        public string DisplayName{get; set;}
        public string Description{get; set;}
        public string Department {get; set;}
        public string Team {get; set;}
    }
}