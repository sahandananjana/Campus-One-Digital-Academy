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
    public partial class File_Form : Form
    {
        public File_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meinmenu menu = new meinmenu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginform login = new loginform();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnFileMainMenu_Click(object sender, EventArgs e)
        {
            meinmenu menu = new meinmenu();
            menu.Show();
            this.Hide();
        }

        private void btnFileLogOut_Click(object sender, EventArgs e)
        {
            loginform login = new loginform();
            login.Show();
            this.Hide();
        }

        private void btnExitSystem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void File_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
