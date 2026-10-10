using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace application1
{
    public partial class registrationform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Final_Project1;Integrated Security=True;TrustServerCertificate=True");
        public registrationform()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmdRegNo.Text = "";
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtHome.Clear();
            txtParent.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure Do you really want" +
                "to Delete this Record...?", "Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("connectionstring"))
                    {
                        con.Open();
                        string sqlquery = "delete from student where reg_no = @reg_no";

                        using (SqlCommand cmd = new SqlCommand(sqlquery, con))
                        {
                            cmd.Parameters.AddWithValue("@reg_no", cmdRegNo.Text);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                                MessageBox.Show("record delete successfully",
                                    "delete student", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            else
                                MessageBox.Show("record not found", "delete student",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:" + ex.Message);
                }















            }
        }

        private void InkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            meinmenu dashboard = new meinmenu();
            dashboard.Show();
        }

        private void InkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                string gender = rbMale.Checked ? "Male" : "Female";

                string query = "INSERT INTO Student (Reg_NO, FirstName, LastName, DOB, Gender, Address, Email, MobilePhone, HomePhone, ParentName, NIC, ContactNumber) VALUES (@reg, @fname, @lname, @dob, @gender, @address, @email, @mobile, @home, @parent, @nic, @contact)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@reg", cmdRegNo.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@home", txtHome.Text);
                cmd.Parameters.AddWithValue("@parent", txtParent.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }






        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string gender = rbMale.Checked ? "Male" : "Female";

                string query = "UPDATE Student SET FirstName=@fname, LastName=@lname, DOB=@dob, Gender=@gender, Address=@address, Email=@email, MobilePhone=@mobile, HomePhone=@home, ParentName=@parent, NIC=@nic, ContactNumber=@contact WHERE Reg_NO=@reg";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@reg", cmdRegNo.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@home", txtHome.Text);
                cmd.Parameters.AddWithValue("@parent", txtParent.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void registrationform_Load(object sender, EventArgs e)
        {

        }
    }
}
