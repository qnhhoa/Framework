using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Payment
    {
        public string MaHD { get; set; }
        public string Username { get; set; }
        public string Method { get; set; }
        public string TongTien { get; set; }
        public string Trangthai { get; set; }
        public string GiaSP { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Note { get; set; }
        public string NgayNH { get; set; }
        public List<Product> Listproduct { get; set; }
    }
}