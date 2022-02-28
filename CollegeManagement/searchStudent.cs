using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class searchStudent : Form
    {
        public searchStudent()
        {
            InitializeComponent();
        }

        

        private void searchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select newAdmission.NAID as Student_Id,newAdmission.fname as Full_Name,newAdmission.fathername as Father_name,newAdmission.gender as Gender,newAdmission.dob as DOB,newAdmission.mobno as Mobile,newAdmission.email as Email_Id,newAdmission.semester as Semester,newAdmission.course as Course,newAdmission.sname as School,newAdmission.duration as Duration,newAdmission.addres as Address,fees.fee as Fees from newAdmission inner join fees on newAdmission.NAID=fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (regNoTV.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select * from newAdmission where NAID ="+regNoTV.Text+"";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select newAdmission.NAID as Student_Id,newAdmission.fname as Full_Name,newAdmission.fathername as Father_name,newAdmission.gender as Gender,newAdmission.dob as DOB,newAdmission.mobno as Mobile,newAdmission.email as Email_Id,newAdmission.semester as Semester,newAdmission.course as Course,newAdmission.sname as School,newAdmission.duration as Duration,newAdmission.addres as Address,fees.fee as Fees from newAdmission inner join fees on newAdmission.NAID=fees.NAID";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                }
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select newAdmission.NAID as Student_Id,newAdmission.fname as Full_Name,newAdmission.fathername as Father_name,newAdmission.gender as Gender,newAdmission.dob as DOB,newAdmission.mobno as Mobile,newAdmission.email as Email_Id,newAdmission.semester as Semester,newAdmission.course as Course,newAdmission.sname as School,newAdmission.duration as Duration,newAdmission.addres as Address,fees.fee as Fees from newAdmission inner join fees on newAdmission.NAID=fees.NAID";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
