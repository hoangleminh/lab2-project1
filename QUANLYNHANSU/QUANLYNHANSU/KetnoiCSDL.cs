using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public class KetnoiCSDL
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-R3VALK2\HOANGSV;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        DataTable dt2 = new DataTable();
        public void themNHANSU(string ten, string maso, string quequan, DateTime ngaysinh, string gioitinh, string sdt)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "NHANSU_ADD";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("ten", SqlDbType.NVarChar)).Value = ten;
                com2.Parameters.Add(new SqlParameter("ngaysinh", SqlDbType.DateTime)).Value = ngaysinh;
                com2.Parameters.Add(new SqlParameter("gioitinh", SqlDbType.NVarChar)).Value = gioitinh;
                com2.Parameters.Add(new SqlParameter("quequan", SqlDbType.NVarChar)).Value = quequan;
                com2.Parameters.Add(new SqlParameter("maso", SqlDbType.NChar)).Value = maso;
                com2.Parameters.Add(new SqlParameter("sdt", SqlDbType.NChar)).Value = sdt;

                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void suaNHANSU(string ten, string maso, string quequan, DateTime ngaysinh, string gioitinh, string sdt)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "NHANSU_UPDATE";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("ten", SqlDbType.NVarChar)).Value = ten;
                com2.Parameters.Add(new SqlParameter("maso", SqlDbType.NChar)).Value = maso;
                com2.Parameters.Add(new SqlParameter("quequan", SqlDbType.NVarChar)).Value = quequan;
                com2.Parameters.Add(new SqlParameter("ngaysinh", SqlDbType.DateTime)).Value = ngaysinh;
                com2.Parameters.Add(new SqlParameter("gioitinh", SqlDbType.NVarChar)).Value = gioitinh;
                com2.Parameters.Add(new SqlParameter("sdt", SqlDbType.NChar)).Value = sdt;
                
                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void xoaNHANSU(string maso)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql2 = "NHANSU_DELETE";
                SqlCommand com2 = new SqlCommand(sql2, con2);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.Add(new SqlParameter("maso", SqlDbType.NChar)).Value = maso;

                com2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }

        public void loadNHANSU(DataGridView dGVNHANSU)
        {
            try
            {
                if (con2.State == ConnectionState.Closed)
                    con2.Open();
                string sql = "NHANSU_LOAD";
                SqlCommand com2 = new SqlCommand(sql, con2);
                com2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da2 = new SqlDataAdapter(com2);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dGVNHANSU.DataSource = dt2;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                con2.Close();
            }
        }
    }
}
