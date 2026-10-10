using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application1
{
    public partial class meinmenu : Form
    {
        public meinmenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                loginform login = new loginform();
                login.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }




        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button eka wada!");
            registrationform studentForm = new registrationform();
            studentForm.Show();
            this.Hide();
        }
        private void linkLabelfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            teachers_registrationform teacherForm = new teachers_registrationform();
            teacherForm.Show();
            this.Hide();
        }

        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            registrationform studentForm = new registrationform();
            studentForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help_form help = new Help_form();
            help.Show();
        }

        private void exitToolStripMenuItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File_Form fileForm = new File_Form();
            fileForm.Show();
            this.Hide();
        }

        private void meinmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
