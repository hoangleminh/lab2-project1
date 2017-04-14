using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYNHANSU
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        DataTable dt;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R3VALK2\HOANGSV;Initial Catalog=QUANLYNHANSU;Integrated Security=True");
        private DataTable checkLogin(string username, string password)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "LOGIN_CHECK";
            SqlCommand comd = new SqlCommand(sql,con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("user",SqlDbType.NVarChar)).Value=username;
            comd.Parameters.Add(new SqlParameter("pass",SqlDbType.NVarChar)).Value=password;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            con.Open();
            string user = txtUSERNAME.Text.Trim();
            string pass = txtPASSWORD.Text.Trim();
            dt = new DataTable();
            dt = checkLogin(user,pass);
            if(dt.Rows.Count>0)
            {
                MENU frm2 = new MENU();
                frm2.Show();
                MessageBox.Show("Login sucessfully","Warning");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username or password!","Warning");
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
