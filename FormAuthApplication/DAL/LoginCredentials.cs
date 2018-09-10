using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormAuthApplication.DAL
{
    public class LoginCredentials
    {
        [Key]
        public string UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailID { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
