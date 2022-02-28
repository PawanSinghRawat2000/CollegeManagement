using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class searchTeacher : Form
    {
        public searchTeacher()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (teachID.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select tID,fname,gender,dob,mobno,email,addres from Teachers where tID=" + teachID.Text + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                    setPhoto();
                }
            }
            catch
            {
                MessageBox.Show("No result found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                imageIV.Image = originalicon;
            }               
        }

        private void setPhoto()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select photo from Teachers where tID=" + teachID.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);

                imageIV.Image = new Bitmap(ms);

            }

        }

        Image originalicon;
        private void searchTeacher_Load(object sender, EventArgs e)
        {
            originalicon = imageIV.Image;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select tID,fname,gender,dob,mobno,email,addres from Teachers";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
    
}
