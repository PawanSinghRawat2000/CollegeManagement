using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class addTeacher : Form
    {
        public addTeacher()
        {
            InitializeComponent();
        }

        Image originalImage;
        private void addTeacher_Load(object sender, EventArgs e)
        {
            originalImage = picIV.Image;
        }
        String photopath;
        byte[] binaryphoto;
        private void uploadButtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp"; 
            file.Title = "Please Upload an Image";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picIV.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath,FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();

            }
        }
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-I6NLIR2J;database=college;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                String gender = "";
                if (radioButtonM.Checked) gender = "M";
                else if (radioButtonF.Checked) gender = "F";
                else
                {
                    gender = "others";
                }



                cmd.CommandText = "insert into Teachers(fname,gender,dob,mobno,email,photo,addres)values('" + FnameTV.Text + "','" + gender + "','" + dateTimePicker1.Text + "','" + mobTV.Text + "','" + EmailTV.Text + "',@pic,'" + addressTV.Text + "')";
                MemoryStream ms = new MemoryStream();
                picIV.Image.Save(ms, ImageFormat.Jpeg);
                byte[] pic = ms.ToArray();
                cmd.Parameters.AddWithValue("@pic", pic);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                if (MessageBox.Show("Details saves successfully", "SUCCESS", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    FnameTV.Text = "";
                    radioButtonF.Checked = false;
                    radioButtonM.Checked = false;
                    radioButtonOthers.Checked = false;
                    dateTimePicker1.ResetText();
                    addressTV.Clear();
                    mobTV.Clear();
                    EmailTV.Clear();
                    picIV.Image = originalImage;
                    
                }
            }
            catch
            {
                MessageBox.Show("Fill Details Carefully", "Failed", MessageBoxButtons.OK);
                

            }
            
            


        }

        
    }
}
