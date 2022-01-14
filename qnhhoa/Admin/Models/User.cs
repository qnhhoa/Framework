using System;
namespace Admin.Models
{
    public class User
    {
        private string username;
        private string password;
        private string hoten;
        private string sdt;
        private string diachi;
        private int role;
        private string email;
        private string picture;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
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
        public int Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public User(string username, string password, string hoten, string diachi, string sdt, int role, string email,string picture)
        {
            this.username = username;
            this.password = password;
            this.hoten = hoten;
            this.diachi = diachi;
            this.sdt = sdt;
            this.role = role;
            this.email = email;
            this.picture = picture;
        }
        public User()
        {
        }
    }
}
