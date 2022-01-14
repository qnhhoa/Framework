using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Admin.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }

        public StoreContext(string connectionString) 
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        //Body
        public List<Body> GetBody()
        {
            List<Body> list = new List<Body>();          
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=2";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                //dynamic stuff = JsonConvert.DeserializeObject("Photo");
                
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Body()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
/*                            Photomain = JsonConvert.DeserializeObject("Photo").ToString(),*/
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"]),
                        }); ;
                    }
                    
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<Body> SearchBody(string hihi)
        {
            List<Body> list = new List<Body>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=2 AND TenSP Like @hi union select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=2 AND nhacc.TenNcc Like @hi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hi", hihi);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Body()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int DeleteBody(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from sanpham where SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public Body ViewBody(string Id)
        {
            Body bd = new Body();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select SpID, TenSP, sanpham.Photo, MoTa, MaLSP, GiaSP, SL, BrandID FROM sanpham WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    bd.ID = reader["SpID"].ToString();
                    bd.Tensp = reader["TenSP"].ToString();
                    bd.Photo = reader["Photo"].ToString();
                    dynamic stuff = JsonConvert.DeserializeObject(bd.Photo);
                    bd.Photomain = stuff.PhotoMain;
                    bd.Description = reader["MoTa"].ToString();
                    bd.Loaisp = reader["MaLSP"].ToString();
                    bd.Cost = reader["GiaSP"].ToString();
                    bd.Mabrand = reader["BrandID"].ToString();
                    bd.Qty = Convert.ToInt32(reader["SL"]);
                }
            }
            return (bd);
        }
        public int UpdateBody(Body bd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update sanpham set SpID=@ID, TenSP=@Tensp,Photo=@Photo,MoTa=@Description,MaLSP=@Loaisp,GiaSP=@Cost,BrandID=@Mabrand,SL=@Qty WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", bd.ID);
                cmd.Parameters.AddWithValue("Tensp", bd.Tensp);
                cmd.Parameters.AddWithValue("Photo", bd.Photo);
                cmd.Parameters.AddWithValue("Description", bd.Description);
                cmd.Parameters.AddWithValue("Loaisp", bd.Loaisp);
                cmd.Parameters.AddWithValue("Cost", bd.Cost);
                cmd.Parameters.AddWithValue("Mabrand", bd.Mabrand);
                cmd.Parameters.AddWithValue("Qty", bd.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertBody(Body bd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into sanpham (SpID, TenSP, Photo,Mota, MaLSP, GiaSP,SL, BrandID) values(@ID, @Tensp, @Photo, @Description, @Loaisp,@Cost,@Qty,@Mabrand)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", bd.ID);
                cmd.Parameters.AddWithValue("Tensp", bd.Tensp);
                cmd.Parameters.AddWithValue("Photo", bd.Photo);
                cmd.Parameters.AddWithValue("Description", bd.Description);
                cmd.Parameters.AddWithValue("Loaisp", bd.Loaisp);
                cmd.Parameters.AddWithValue("Cost", bd.Cost);
                cmd.Parameters.AddWithValue("Mabrand", bd.Mabrand);
                cmd.Parameters.AddWithValue("Qty", bd.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        //Skin
        public List<Skin> GetSkin()
        {
            List<Skin> list = new List<Skin>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=1";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Skin()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int DeleteSkin(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from sanpham where SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<Skin> SearchSkin(string hihi)
        {
            List<Skin> list = new List<Skin>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=1 AND TenSP Like @hi union select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=1 AND nhacc.TenNcc Like @hi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hi", hihi);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Skin()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public Skin ViewSkin(string Id)
        {
            Skin sk = new Skin();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select SpID, TenSP, sanpham.Photo, MoTa, MaLSP, GiaSP, SL, BrandID FROM sanpham WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    sk.ID = reader["SpID"].ToString();
                    sk.Tensp = reader["TenSP"].ToString();
                    sk.Photo = reader["Photo"].ToString();
                    dynamic stuff = JsonConvert.DeserializeObject(sk.Photo);
                    sk.Photomain = stuff.PhotoMain;
                    sk.Description = reader["MoTa"].ToString();
                    sk.Loaisp = reader["MaLSP"].ToString();
                    sk.Cost = reader["GiaSP"].ToString();
                    sk.Mabrand = reader["BrandID"].ToString();
                    sk.Qty = Convert.ToInt32(reader["SL"]);
                }
            }
            return (sk);
        }
        public int UpdateSkin(Skin sk)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update sanpham set SpID=@ID, TenSP=@Tensp,Photo=@Photo,MoTa=@Description,MaLSP=@Loaisp,GiaSP=@Cost,BrandID=@Mabrand,SL=@Qty WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", sk.ID);
                cmd.Parameters.AddWithValue("Tensp", sk.Tensp);
                cmd.Parameters.AddWithValue("Photo", sk.Photo);
                cmd.Parameters.AddWithValue("Description", sk.Description);
                cmd.Parameters.AddWithValue("Loaisp", sk.Loaisp);
                cmd.Parameters.AddWithValue("Cost", sk.Cost);
                cmd.Parameters.AddWithValue("Mabrand", sk.Mabrand);
                cmd.Parameters.AddWithValue("Qty", sk.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertSkin(Skin sk)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into sanpham (SpID, TenSP, Photo,Mota, MaLSP, GiaSP,SL, BrandID) values(@ID, @Tensp, @Photo, @Description, @Loaisp,@Cost,@Qty,@Mabrand)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", sk.ID);
                cmd.Parameters.AddWithValue("Tensp", sk.Tensp);
                cmd.Parameters.AddWithValue("Photo", sk.Photo);
                cmd.Parameters.AddWithValue("Description", sk.Description);
                cmd.Parameters.AddWithValue("Loaisp", sk.Loaisp);
                cmd.Parameters.AddWithValue("Cost", sk.Cost);
                cmd.Parameters.AddWithValue("Mabrand", sk.Mabrand);
                cmd.Parameters.AddWithValue("Qty", sk.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        //Hair
        public List<Hair> GetHair()
        {
            List<Hair> list = new List<Hair>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=3";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Hair()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public List<Hair> SearchHair(string hihi)
        {
            List<Hair> list = new List<Hair>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=3 AND TenSP Like @hi union select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=3 AND nhacc.TenNcc Like @hi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hi", hihi);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Hair()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int DeleteHair(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from sanpham where SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public Hair ViewHair(string Id)
        {
            Hair hr = new Hair();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select SpID, TenSP, sanpham.Photo, MoTa, MaLSP, GiaSP, SL, BrandID FROM sanpham WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    hr.ID = reader["SpID"].ToString();
                    hr.Tensp = reader["TenSP"].ToString();
                    hr.Photo = reader["Photo"].ToString();
                    dynamic stuff = JsonConvert.DeserializeObject(hr.Photo);
                    hr.Photomain = stuff.PhotoMain;
                    hr.Description = reader["MoTa"].ToString();
                    hr.Loaisp = reader["MaLSP"].ToString();
                    hr.Cost = reader["GiaSP"].ToString();
                    hr.Mabrand = reader["BrandID"].ToString();
                    hr.Qty = Convert.ToInt32(reader["SL"]);
                }
            }
            return (hr);
        }
        public int UpdateHair(Hair hr)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update sanpham set SpID=@ID, TenSP=@Tensp,Photo=@Photo,MoTa=@Description,MaLSP=@Loaisp,GiaSP=@Cost,BrandID=@Mabrand,SL=@Qty WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", hr.ID);
                cmd.Parameters.AddWithValue("Tensp", hr.Tensp);
                cmd.Parameters.AddWithValue("Photo", hr.Photo);
                cmd.Parameters.AddWithValue("Description", hr.Description);
                cmd.Parameters.AddWithValue("Loaisp", hr.Loaisp);
                cmd.Parameters.AddWithValue("Cost", hr.Cost);
                cmd.Parameters.AddWithValue("Mabrand", hr.Mabrand);
                cmd.Parameters.AddWithValue("Qty", hr.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertHair(Hair hr)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into sanpham (SpID, TenSP, Photo,Mota, MaLSP, GiaSP,SL, BrandID) values(@ID, @Tensp, @Photo, @Description, @Loaisp,@Cost,@Qty,@Mabrand)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", hr.ID);
                cmd.Parameters.AddWithValue("Tensp", hr.Tensp);
                cmd.Parameters.AddWithValue("Photo", hr.Photo);
                cmd.Parameters.AddWithValue("Description", hr.Description);
                cmd.Parameters.AddWithValue("Loaisp", hr.Loaisp);
                cmd.Parameters.AddWithValue("Cost", hr.Cost);
                cmd.Parameters.AddWithValue("Mabrand", hr.Mabrand);
                cmd.Parameters.AddWithValue("Qty", hr.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        //Makeup
        public List<Makeup> GetMakeup()
        {
            List<Makeup> list = new List<Makeup>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=4";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Makeup()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<Makeup> SearchMakeup(string hihi)
        {
            List<Makeup> list = new List<Makeup>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=4 AND TenSP Like @hi union select SpID, TenSP, sanpham.Photo, MoTa, loaisp.TenLSP, GiaSP, SL, nhacc.TenNcc from nhacc, sanpham,loaisp where sanpham.MaLSP=loaisp.MaLSP and sanpham.BrandID=nhacc.BrandID and sanpham.MaLSP=4 AND nhacc.TenNcc Like @hi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hi", hihi);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Makeup()
                        {
                            ID = reader["SpID"].ToString(),
                            Tensp = reader["TenSP"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Description = reader["MoTa"].ToString(),
                            Tenloaisp = reader["TenLSP"].ToString(),
                            Cost = reader["GiaSP"].ToString(),
                            Brand = reader["TenNcc"].ToString(),
                            Qty = Convert.ToInt32(reader["SL"])
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int DeleteMakeup(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from sanpham where SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public Makeup ViewMakeup(string Id)
        {
            Makeup mk = new Makeup();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select SpID, TenSP, sanpham.Photo, MoTa, MaLSP, GiaSP, SL, BrandID FROM sanpham WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    mk.ID = reader["SpID"].ToString();
                    mk.Tensp = reader["TenSP"].ToString();
                    mk.Photo = reader["Photo"].ToString();
                    dynamic stuff = JsonConvert.DeserializeObject(mk.Photo);
                    mk.Photomain = stuff.PhotoMain;
                    mk.Description = reader["MoTa"].ToString();
                    mk.Loaisp = reader["MaLSP"].ToString();
                    mk.Cost = reader["GiaSP"].ToString();
                    mk.Mabrand = reader["BrandID"].ToString();
                    mk.Qty = Convert.ToInt32(reader["SL"]);
                }
            }
            return (mk);
        }
        public int UpdateMakeup(Makeup mk)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update sanpham set SpID=@ID, TenSP=@Tensp,Photo=@Photo,MoTa=@Description,MaLSP=@Loaisp,GiaSP=@Cost,BrandID=@Mabrand,SL=@Qty WHERE SpID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", mk.ID);
                cmd.Parameters.AddWithValue("Tensp", mk.Tensp);
                cmd.Parameters.AddWithValue("Photo", mk.Photo);
                cmd.Parameters.AddWithValue("Description", mk.Description);
                cmd.Parameters.AddWithValue("Loaisp", mk.Loaisp);
                cmd.Parameters.AddWithValue("Cost", mk.Cost);
                cmd.Parameters.AddWithValue("Mabrand", mk.Mabrand);
                cmd.Parameters.AddWithValue("Qty", mk.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertMakeup(Makeup mk)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into sanpham (SpID, TenSP, Photo,Mota, MaLSP, GiaSP,SL, BrandID) values(@ID, @Tensp, @Photo, @Description, @Loaisp,@Cost,@Qty,@Mabrand)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", mk.ID);
                cmd.Parameters.AddWithValue("Tensp", mk.Tensp);
                cmd.Parameters.AddWithValue("Photo", mk.Photo);
                cmd.Parameters.AddWithValue("Description", mk.Description);
                cmd.Parameters.AddWithValue("Loaisp", mk.Loaisp);
                cmd.Parameters.AddWithValue("Cost", mk.Cost);
                cmd.Parameters.AddWithValue("Mabrand", mk.Mabrand);
                cmd.Parameters.AddWithValue("Qty", mk.Qty);
                return (cmd.ExecuteNonQuery());
            }
        }
        //Brand
        public List<Brand> GetBrand()
        {
            List<Brand> list = new List<Brand>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * from nhacc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Brand()
                        {
                            BrandID = reader["BrandID"].ToString(),
                            TenNcc = reader["TenNcc"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public Brand ViewBrand(string Id)
        {
            Brand br = new Brand();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * from nhacc WHERE BrandID=@BrandID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("BrandID", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    br.BrandID = reader["BrandID"].ToString();
                    br.TenNcc = reader["TenNcc"].ToString();
                }
            }
            return (br);
        }
        //User management
        public List<User> GetUser()
        {
            List<User> list = new List<User>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from dangnhap";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            Username = reader["Username"].ToString(),
                            Password = reader["password"].ToString(),
                            Hoten = reader["HoTen"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Diachi = reader["DiaChi"].ToString(),
                            Role = Convert.ToInt32(reader["cRole"]),
                            Email = reader["Email"].ToString()
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<User> SearchUser(string hihi)
        {
            List<User> list = new List<User>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from dangnhap where Username LIKE @hi or HoTen LIKE @hi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hi", hihi);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            Username = reader["Username"].ToString(),
                            Password = reader["password"].ToString(),
                            Hoten = reader["HoTen"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Diachi = reader["DiaChi"].ToString(),
                            Role = Convert.ToInt32(reader["cRole"]),
                            Email = reader["Email"].ToString()
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public List<User> GetUserbyRole()
        {
            List<User> list = new List<User>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from dangnhap order by Role desc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User()
                        {
                            Username = reader["Username"].ToString(),
                            Password = reader["password"].ToString(),
                            Hoten = reader["HoTen"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Diachi = reader["DiaChi"].ToString(),
                            Role = Convert.ToInt32(reader["cRole"]),
                            Email = reader["Email"].ToString()
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int DeleteUser(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from dangnhap where Username=@Username";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("Username", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public User ViewDN(string Id)
        {
            User ur = new User();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from dangnhap where Username=@Username";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("Username", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    ur.Username = reader["Username"].ToString();
                    ur.Password = reader["password"].ToString();
                    ur.Hoten = reader["HoTen"].ToString();
                    ur.SDT = reader["SDT"].ToString();
                    ur.Diachi = reader["DiaChi"].ToString();
                    ur.Role = Convert.ToInt32(reader["cRole"]);
                    ur.Email = reader["Email"].ToString();
                    ur.Picture = reader["picture"].ToString();
                    
                }
            }
            return (ur);
        }
        public int UpdateUser(User ur)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update dangnhap set HoTen = @hoten,picture = @picture, password = @password, SDT = @sdt, DiaChi = @diachi, cRole = @role, Email = @email where Username=@username";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hoten", ur.Hoten);
                cmd.Parameters.AddWithValue("password", ur.Password);
                cmd.Parameters.AddWithValue("sdt", ur.SDT);
                cmd.Parameters.AddWithValue("diachi", ur.Diachi);
                cmd.Parameters.AddWithValue("role", ur.Role);
                cmd.Parameters.AddWithValue("email", ur.Email);
                cmd.Parameters.AddWithValue("username", ur.Username);
                cmd.Parameters.AddWithValue("picture", ur.Picture);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertDN(User ur)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into dangnhap (Username, password, HoTen, DiaChi, SDT, cRole, Email) values(@username, @password, @hoten, @diachi, @sdt,@role,@email)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("username", ur.Username);
                cmd.Parameters.AddWithValue("password", ur.Password);
                cmd.Parameters.AddWithValue("hoten", ur.Hoten);
                cmd.Parameters.AddWithValue("sdt", ur.SDT);
                cmd.Parameters.AddWithValue("diachi", ur.Diachi);
                cmd.Parameters.AddWithValue("role", ur.Role);
                cmd.Parameters.AddWithValue("email", ur.Email);
                return (cmd.ExecuteNonQuery());
            }
        }
        //Order management
        public List<Order> GetOrder()
        {
            List<Order> list = new List<Order>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from hoadon, donhang where hoadon.MaHD = donhang.MaHD order by NgayHD desc;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Order()
                        {
                            MaHD = reader["MaHD"].ToString(),
                            Username = reader["Username"].ToString(),
                            NgayNH = reader["NgayNH"].ToString(),
                            Diachi = reader["Address"].ToString(),
                            SDT = reader["PhoneNumber"].ToString(),
                            Tongtien = Convert.ToInt32(reader["TongTien"]),
                            Phuongthuc = reader["Method"].ToString(),
                            Trangthai = reader["Trangthai"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<Order> SearchOrder(string hihi)
        {
            List<Order> list = new List<Order>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select *from hoadon, donhang where hoadon.MaHD = donhang.MaHD and NgayHD Like @hi union select * from hoadon, donhang where hoadon.MaHD = donhang.MaHD and Username Like @hi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hi", hihi);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Order()
                        {
                            MaHD = reader["MaHD"].ToString(),
                            Username = reader["Username"].ToString(),
                            NgayNH = reader["NgayNH"].ToString(),
                            Diachi = reader["Address"].ToString(),
                            SDT = reader["PhoneNumber"].ToString(),
                            Tongtien = Convert.ToInt32(reader["TongTien"]),
                            Phuongthuc = reader["Method"].ToString(),
                            Trangthai = reader["Trangthai"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        public int DeleteOrder(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from hoadon where MaHD=@MaHD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaHD", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public Order ViewOrder(string Id)
        {
            Order or = new Order();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from hoadon, donhang where donhang.MaHD=donhang.MaHD and hoadon.MaHD = @MaHD;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaHD", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    or.Username = reader["Username"].ToString();
                    or.Fullname = reader["Fullname"].ToString();
                    or.NgayNH = reader["NgayNH"].ToString();
                    or.Diachi = reader["Address"].ToString();
                    or.SDT = reader["PhoneNumber"].ToString();
                    or.Tongtien = Convert.ToInt32(reader["TongTien"]);
                    or.Ghichu = reader["Note"].ToString();
                    or.Phuongthuc = reader["Method"].ToString();
                    or.Trangthai = reader["Trangthai"].ToString();
                    or.MaHD = reader["MaHD"].ToString();
                }
            }
            return (or);
        }
        public int DeleteCthd(string Id, string Ok)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from cthd where MaHD=@MaHD and SpID = @MaSP";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaHD", Id);
                cmd.Parameters.AddWithValue("MaSP", Ok);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<Order> ViewCthd(string Id)
        {
            List<Order> list = new List<Order>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from cthd,sanpham where sanpham.SpID=cthd.SpID and MaHD=@MaHD";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaHD", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Order()
                        {
                        TenSP = reader["TenSP"].ToString(),
                        MaSP = reader["SpID"].ToString(),
                        MaHD = reader["MaHD"].ToString(),
                        GiaSP = Convert.ToInt32(reader["GiaSP"]),
                        SL = Convert.ToInt32(reader["SL"])
                    });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int Updatecthd(Order or)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "Update cthd set SL=@SL Where MaHD=@MaHD; ";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("SL", or.SL);
                cmd.Parameters.AddWithValue("MaHD", or.MaHD);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateOrder(Order or)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update hoadon set Username=@Username, Address=@Address, PhoneNumber=@PhoneNumber, TongTien=@TongTien, Method=@Method, Fullname =@Fullname Where MaHD=@MaHD; Update donhang set NgayNH=@NgayNH, Trangthai = @Trangthai where MaHD=@MaHD;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("Username", or.Username);
                cmd.Parameters.AddWithValue("Fullname", or.Fullname);
                cmd.Parameters.AddWithValue("NgayNH", or.NgayNH);
                cmd.Parameters.AddWithValue("Trangthai", or.Trangthai);
                cmd.Parameters.AddWithValue("SL", or.SL);
                cmd.Parameters.AddWithValue("Address", or.Diachi);
                cmd.Parameters.AddWithValue("PhoneNumber", or.SDT);
                cmd.Parameters.AddWithValue("TongTien", or.Tongtien);
                cmd.Parameters.AddWithValue("Method", or.Phuongthuc);
                cmd.Parameters.AddWithValue("MaHD", or.MaHD);
                return (cmd.ExecuteNonQuery());
            }
        }
        //Blog management
        public List<Blog> GetBlog()
        {
            List<Blog> list = new List<Blog>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from blog";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Blog()
                        {
                            ID = reader["ID"].ToString(),
                            Title = reader["title"].ToString(),
                            Author = reader["author"].ToString(),
                            Photo = reader["photo"].ToString(),
                            Content = reader["content"].ToString(),
                            Link_post = reader["link_post"].ToString()
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<Blog> SearchBlog(string hihi)
        {
            List<Blog> list = new List<Blog>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from blog where author like @hi union select * from blog where title like @hi order by ID desc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("hi", hihi);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Blog()
                        {
                            ID = reader["ID"].ToString(),
                            Title = reader["title"].ToString(),
                            Author = reader["author"].ToString(),
                            Photo = reader["photo"].ToString(),
                            Content = reader["content"].ToString(),
                            Link_post = reader["link_post"].ToString()
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
     
        public int DeleteBlog(string Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from blog where ID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public Blog ViewBlog(string Id)
        {
            Blog ur = new Blog();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from Blog where ID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    ur.ID = reader["ID"].ToString();
                    ur.Title = reader["title"].ToString();
                    ur.Author = reader["author"].ToString();
                    ur.Photo = reader["photo"].ToString();
                    ur.Content = reader["content"].ToString();
                    ur.Link_post = reader["link_post"].ToString();  

                }
            }
            return (ur);
        }
        public int UpdateBlog(Blog ur)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update blog set title=@title,author=@author,photo=@photo,content=@content,link_post=@link_post WHERE ID=@ID";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", ur.ID);
                cmd.Parameters.AddWithValue("title", ur.Title);
                cmd.Parameters.AddWithValue("author", ur.Author);
                cmd.Parameters.AddWithValue("photo", ur.Photo);
                cmd.Parameters.AddWithValue("content", ur.Content);
                cmd.Parameters.AddWithValue("link_post", ur.Link_post);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertBlog(Blog ur)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into blog (title,author,photo,content,link_post) values(@title,@author,@photo, @content, @link_post)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", ur.ID);
                cmd.Parameters.AddWithValue("title", ur.Title);
                cmd.Parameters.AddWithValue("author", ur.Author);
                cmd.Parameters.AddWithValue("photo", ur.Photo);
                cmd.Parameters.AddWithValue("content", ur.Content);
                cmd.Parameters.AddWithValue("link_post", ur.Link_post);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<Blog> HighCharts()
        {
            List<Blog> list = new List<Blog>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from blog";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Blog()
                        {
                            ID = reader["ID"].ToString(),
                            Title = reader["title"].ToString(),
                            Author = reader["author"].ToString(),
                            Photo = reader["photo"].ToString(),
                            Content = reader["content"].ToString(),
                            Link_post = reader["link_post"].ToString()
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        //Login
        public Login ViewLogin(string Id)
        {
            Login ur = new Login();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from dangnhap where Email=@Email";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ID", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    ur.Email = reader["Email"].ToString();
                    ur.Username = reader["Username"].ToString();;
                }
            }
            return (ur);
        }
        public StoreContext()
        {
        }
    }
}
