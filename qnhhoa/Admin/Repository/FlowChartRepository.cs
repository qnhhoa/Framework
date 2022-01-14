using Chart.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Repository
{
    public class FlowChartRepository : ConnectionDb
    {
        public MySqlConnection conn;
        public FlowChartRepository()
        {
            conn = getConnection();
        }
        public async Task<List<BarChart>> GetBarChart()
        {
            try
            {
                await conn.OpenAsync();
                string sql = @"SELECT EXTRACT(DAY FROM NgayHD) as ngay, avg(Rating) as rt, 
                        Trangthai, sanpham.SpID from hoadon, danhgia, donhang, sanpham WHERE hoadon.MaHD=donhang.MaHD 
                        and sanpham.SpID = danhgia.SpID GROUP BY Trangthai, sanpham.SpID";
                List<BarChart> bars = conn.Query<BarChart>(sql).ToList();
                return bars;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                await conn.CloseAsync();
            }

        }
        public async Task<List<CircleChart>> GetCircles()
        {
            try
            {
                await conn.OpenAsync();
                string sql = @"SELECT EXTRACT(MONTH from NgayHD) as month, sum(TongTien) as Tong from donhang, 
                            hoadon where donhang.MaHD=hoadon.MaHD GROUP by EXTRACT(MONTH from NgayHD)";
                List<CircleChart> bars = conn.Query<CircleChart>(sql).ToList();
                return bars;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                await conn.CloseAsync();
            }
        }
    }

}