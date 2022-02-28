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
    public partial class fee : Form
    {
        public fee()
        {
            InitializeComponent();
        }

        private void regId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(regId.Text != "" )
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select fname,fathername,duration from newAdmission where NAID = " + regId.Text + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0)
                    {

                        fullNameTV.Text = ds.Tables[0].Rows[0][0].ToString();
                        fatherName.Text = ds.Tables[0].Rows[0][1].ToString();
                        durationTV.Text = ds.Tables[0].Rows[0][2].ToString();

                    }
                    else
                    {
                        fullNameTV.Text = "__________";
                        fatherName.Text = "__________";
                        durationTV.Text = "__________";

                    }
                }
                else
                {
                    fullNameTV.Text = "__________";
                    fatherName.Text = "__________";
                    durationTV.Text = "__________";

                }

            }
            catch
            {
                fullNameTV.Text = "__________";
                fatherName.Text = "__________";
                durationTV.Text = "__________";

            }


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (regId.Text == "" || feeTV.Text=="")
            {
                MessageBox.Show("Enter details carefully", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID="+regId.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;

                cmd1.CommandText = "insert into fees(NAID,fee) values (" + regId.Text + "," + feeTV.Text + ")";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                if (MessageBox.Show("Fee details updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    regId.Text = "";
                    feeTV.Text = "";
                    fullNameTV.Text = "__________";
                    fatherName.Text = "__________";
                    durationTV.Text = "__________";

                }
            }
            else
            {
                MessageBox.Show("Fees Already Paid", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                regId.Text = "";
                feeTV.Text = "";
                fullNameTV.Text = "__________";
                fatherName.Text = "__________";
                durationTV.Text = "__________";
            }


            

        }
    }
}
