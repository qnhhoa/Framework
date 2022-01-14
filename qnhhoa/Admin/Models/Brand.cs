using System;
namespace Admin.Models
{
    public class Brand
    {
        private string brandID;
        private string tenNcc;
        public string BrandID
        {
            get { return brandID; }
            set { brandID = value; }
        }
        public string TenNcc
        {
            get { return tenNcc; }
            set { tenNcc = value; }
        }       
        public Brand(string brandID, string tenNcc)
        {
            this.brandID = brandID;
            this.tenNcc = tenNcc;
        }
        public Brand()
        {
        }
    }
}
