namespace application1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            // check login credentials
            if (username == "Admin" && password == "Campusone123")
            {
                MessageBox.Show("Login Successful!", "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //Open Registration Form
                meinmenu registrationForm = new meinmenu();
                registrationForm.Show();

                //Hide Login Form 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();

            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
