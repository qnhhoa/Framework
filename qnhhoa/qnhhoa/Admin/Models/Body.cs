using System;
namespace Admin.Models
{
    public class Body
    {
        private string ID;
        private string photo;
        private string brands;
        private string cost;
        private string description;
        private int qty;

        public string SPID
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Brand
        {
            get { return brands; }
            set { brands = value; }
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
        public Body(string ID, string photo, string brands, string cost, string description, int qty)
        {
            this.ID = ID;
            this.photo = photo;
            this.brands = brands;
            this.cost = cost;
            this.description = description;
            this.qty = qty;
        }
        public Body()
        {           
        }
    }
}
