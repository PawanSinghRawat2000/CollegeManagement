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
    public partial class searchIndividual : Form
    {
        public searchIndividual()
        {
            InitializeComponent();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (regidTV.Text != "")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select * from newAdmission where NAID=" + regidTV.Text + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    fullNamelabel.Text = ds.Tables[0].Rows[0][1].ToString();
                    Fnamelabel.Text = ds.Tables[0].Rows[0][2].ToString();
                    genderlabel.Text = ds.Tables[0].Rows[0][3].ToString();
                    doblabel.Text = ds.Tables[0].Rows[0][4].ToString();
                    moblabel.Text = ds.Tables[0].Rows[0][5].ToString();
                    emaillabel.Text = ds.Tables[0].Rows[0][6].ToString();
                    semlabel.Text = ds.Tables[0].Rows[0][7].ToString();
                    courselabel.AutoSize = true;
                    courselabel.MaximumSize = new Size(100, 0);
                    courselabel.Text = ds.Tables[0].Rows[0][8].ToString();
                    snamelabel.Text = ds.Tables[0].Rows[0][9].ToString();
                    yearlabel.Text = ds.Tables[0].Rows[0][10].ToString();
                    addresslabel.AutoSize = true;
                    addresslabel.MaximumSize = new Size(100, 0);
                    addresslabel.Text = ds.Tables[0].Rows[0][11].ToString();

                }
 
            }
            catch
            {
                MessageBox.Show("No records found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fullNamelabel.Text = "__________";
                Fnamelabel.Text = "__________";
                genderlabel.Text = "__________";
                doblabel.Text = "__________";
                moblabel.Text = "__________";
                emaillabel.Text = "__________";
                semlabel.Text = "__________";
                courselabel.Text = "__________";
                snamelabel.Text = "__________";
                yearlabel.Text = "__________";
                addresslabel.Text = "__________";

            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            fullNamelabel.Text = "__________";
            Fnamelabel.Text = "__________";
            genderlabel.Text = "__________";
            doblabel.Text = "__________";
            moblabel.Text = "__________";
            emaillabel.Text = "__________";
            semlabel.Text = "__________";
            courselabel.Text = "__________";
            snamelabel.Text = "__________";
            yearlabel.Text = "__________";
            addresslabel.Text = "__________";
        }
    }
}
