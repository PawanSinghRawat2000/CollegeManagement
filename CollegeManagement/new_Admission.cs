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
    public partial class new_Admission : Form
    {
        public new_Admission()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String fname = TVfullname.Text;
                String fathername = TVfathername.Text;
                String gender = "";
                if (male.Checked)
                {
                    gender = male.Text;
                }
                else if (female.Checked)
                {
                    gender = female.Text;
                }
                else
                {
                    gender = other.Text;
                }
                String dob = dateTimePicker1.Text;
                Int64 mobileno = Int64.Parse(TVmobileNo.Text);
                String email = TVemail.Text;
                String semester = TVsemester.Text;
                String course = TVcourse.Text;
                String sname = TVschoolName.Text;
                String duration = TVduration.Text;
                String addr = TVaddress.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into newAdmission(fname,fathername,gender,dob,mobno,email,semester,course,sname,duration,addres) values ('" + fname + "','" + fathername + "','" + gender + "','" + dob + "','" + mobileno + "','" + email + "','" + semester + "','" + course + "','" + sname + "','" + duration + "','" + addr + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Close();
                if (MessageBox.Show("Data saved. Remember the Registration Id.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    TVfullname.Clear();
                    TVfathername.Clear();
                    male.Checked = false;
                    female.Checked = false;
                    other.Checked = false;
                    TVmobileNo.Clear();
                    TVemail.Clear();
                    TVsemester.ResetText();
                    TVcourse.ResetText();
                    TVschoolName.Clear();
                    TVduration.ResetText();
                    TVaddress.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Fill all details carefully", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TVfullname.Clear();
            TVfathername.Clear();
            male.Checked = false;
            female.Checked = false;
            other.Checked = false;
            TVmobileNo.Clear();
            TVemail.Clear();
            TVsemester.ResetText();
            TVcourse.ResetText();
            TVschoolName.Clear();
            TVduration.ResetText();
            TVaddress.Clear();


        }

        private void new_Admission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(NAID) from newAdmission";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Int64 id = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = (id + 1).ToString();

        }

        
    }
}
