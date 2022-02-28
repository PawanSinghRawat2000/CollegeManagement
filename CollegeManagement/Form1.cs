using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTV.Text;
            String password = passwordTV.Text;
            if(username=="student" && password == "student")
            {
                panel1.Visible = false;
                menuStrip1.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_Admission na = new new_Admission();
            na.Show();

        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            semUpgrade su = new semUpgrade();
            su.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fee f = new fee();
            f.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchStudent st = new searchStudent();
            st.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchIndividual sI = new searchIndividual();
            sI.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTeacher at = new addTeacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTeacher st = new searchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteStudent dt = new deleteStudent();
            dt.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us ab = new About_Us();
            ab.Show();
        }
    }
}
