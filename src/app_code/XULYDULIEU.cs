using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.src.app_code
{
    public class XULYDULIEU
    {
        SqlConnection con;

        public XULYDULIEU()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=MSI;Initial Catalog=QUANLYSINHVIEN;User ID=sa;Password=123456;TrustServerCertificate=True";
        }
        private void MoKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable getTable(String SQL)
        {
            DataTable tb = null;
            try
            {
                this.MoKetNoi();
                SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
                tb = new DataTable();
                adp.Fill(tb);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                this.DongKetNoi();
            }
            return tb;
        }

        public void setStudents(String SQL)
        {
            try
            {
                this.MoKetNoi();
                SqlCommand cmd = new SqlCommand(SQL, con);
                Console.WriteLine("Error");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                this.DongKetNoi();
            }
        }
    }
}