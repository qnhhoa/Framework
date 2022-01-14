using System;
namespace Admin.Models
{
    public class Hair
    {
        private string id;
        private string tensp;
        private string photo;
        private string photomain;
        private string brand;
        private string mabrand;
        private string loaisp;
        private string tenloaisp;
        private string cost;
        private string description;
        private int qty;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        public string Loaisp
        {
            get { return loaisp; }
            set { loaisp = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Photomain
        {
            get { return photomain; }
            set { photomain = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Mabrand
        {
            get { return mabrand; }
            set { mabrand = value; }
        }
        public string Tenloaisp
        {
            get { return tenloaisp; }
            set { tenloaisp = value; }
        }
        public string Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public Hair(string id, string tensp, string photo, string brand, string mabrand, string loaisp, string tenloaisp, string cost, string description, int qty)
        {
            this.id = id;
            this.tensp = tensp;
            this.photo = photo;
            this.brand = brand;
            this.mabrand = mabrand;
            this.loaisp = loaisp;
            this.tenloaisp = tenloaisp;
            this.cost = cost;
            this.description = description;
            this.qty = qty;
        }

        public Hair()
        {
        }
    }
}
