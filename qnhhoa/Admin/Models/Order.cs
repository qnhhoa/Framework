using System;
namespace Admin.Models
{
    public class Order
    {
        private string mahd;
        private string username;
        private string ngayhd;
        private string ngaynh;
        private string tensp;
        private string masp;
        private int sl;
        private int tongtien;
        private int giasp;
        private string diachi;
        private string sdt;
        private string phuongthuc;
        private string ghichu;
        private string trangthai;
        private string fullname;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public string MaHD
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public string NgayHD
        {
            get { return ngayhd; }
            set { ngayhd = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; }
        }
        public string MaSP
        {
            get { return masp; }
            set { masp = value; }
        }
        public int SL
        {
            get { return sl; }
            set { sl = value; }
        }
        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public int GiaSP
        {
            get { return giasp; }
            set { giasp = value; }
        }
        public string NgayNH
        {
            get { return ngaynh; }
            set { ngaynh = value; }
        }
        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        public string Phuongthuc
        {
            get { return phuongthuc; }
            set { phuongthuc = value; }
        }

        public Order(string mahd, string username, string fullname, string ngayhd, string ngaynh, string tensp, int sl, int tongtien,int giasp, string diachi, string sdt, string phuongthuc, string ghichu, string trangthai)
        {
            this.mahd = mahd;
            this.username = username;
            this.fullname = fullname;
            this.ngayhd = ngayhd;
            this.ngaynh = ngaynh;
            this.tensp = tensp;
            this.sl = sl;
            this.tongtien = tongtien;
            this.diachi = diachi;
            this.sdt = sdt;
            this.giasp = giasp;
            this.phuongthuc = phuongthuc;
            this.ghichu = ghichu;
            this.trangthai = trangthai;
        }

        public Order()
        {
        }
    }
}
