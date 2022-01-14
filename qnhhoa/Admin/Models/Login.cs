using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Login
    {
        public string Username { get; set; }

        public string password { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string diaChi { get; set; }
        public string cRole { get; set; }
        public string Email { get; set; }
        public string picture { get; set; }

    }
}
