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

namespace application1
{
    public partial class teachers_registrationform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=desktop-m5ufrer\sqlexpress01;Initial Catalog=Final_Project1;Integrated Security=True;TrustServerCertificate=True");

        public teachers_registrationform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtTeacherFirstName.Text == "First")
            {
                txtTeacherFirstName.Text = "";
                txtTeacherFirstName.ForeColor = Color.SaddleBrown;
            }
        }

        private void txtTeacherFirstName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTeacherFirstName.Text))
            {
                txtTeacherFirstName.Text = "First";
                txtTeacherFirstName.ForeColor = Color.Gray;
            }
        }

        private void textTeacherLastName_Enter(object sender, EventArgs e)
        {
            if (txtTeacherLastName.Text == "Last")
            {
                txtTeacherLastName.Text = "";
                txtTeacherLastName.ForeColor = Color.SaddleBrown;
            }
        }

        private void txtTeacherLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherLastName.Text))
            {
                txtTeacherLastName.Text = "Last";
                txtTeacherLastName.ForeColor = Color.Gray;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnteacherregister_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string gender = rbteacherfemale.Checked ? "Female" : "Male";

                string maritalStatus = "";
                if (rbteachersingle.Checked) maritalStatus = "Single";
                else if (rbteachermarried.Checked) maritalStatus = "Married";
                else if (rbteacherdivorced.Checked) maritalStatus = "Divorced";
                else if (rbteacherwidowed.Checked) maritalStatus = "Widowed";

                string query = "INSERT INTO teacher (FirstName, LastName, Gender, MaritalStatus, Birthdate, Phone, Email, Address, EducationalBackground, TodaysDate) VALUES (@fname, @lname, @gender, @marital, @dob, @phone, @email, @address, @edu, @tdate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fname", txtTeacherFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtTeacherLastName.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@marital", maritalStatus);
                    cmd.Parameters.AddWithValue("@dob", dtpteacherDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@phone", txtteacherphone.Text);
                    cmd.Parameters.AddWithValue("@email", txtteacheremail.Text);
                    cmd.Parameters.AddWithValue("@address", txtteacheraddress.Text);
                    cmd.Parameters.AddWithValue("@edu", txtteachereducational.Text);
                    cmd.Parameters.AddWithValue("@tdate", dtpteachertime.Value.Date);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnteacherupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string gender = rbteacherfemale.Checked ? "Female" : "Male";

                string maritalStatus = "";
                if (rbteachersingle.Checked) maritalStatus = "Single";
                else if (rbteachermarried.Checked) maritalStatus = "Married";
                else if (rbteacherdivorced.Checked) maritalStatus = "Divorced";
                else if (rbteacherwidowed.Checked) maritalStatus = "Widowed";

                // Phone no eka anuwath karanna puluwan, hari Email eka anuwath condition eka liyanna puluwan
                string query = "UPDATE teacher SET FirstName=@fname, LastName=@lname, Gender=@gender, MaritalStatus=@marital, Birthdate=@dob, Email=@email, Address=@address, EducationalBackground=@edu, TodaysDate=@tdate WHERE Phone=@phone";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fname", txtTeacherFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", txtTeacherLastName.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@marital", maritalStatus);
                    cmd.Parameters.AddWithValue("@dob", dtpteacherDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@phone", txtteacherphone.Text);
                    cmd.Parameters.AddWithValue("@email", txtteacheremail.Text);
                    cmd.Parameters.AddWithValue("@address", txtteacheraddress.Text);
                    cmd.Parameters.AddWithValue("@edu", txtteachereducational.Text);
                    cmd.Parameters.AddWithValue("@tdate", dtpteachertime.Value.Date);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnteacherclear_Click(object sender, EventArgs e)
        {
            txtTeacherFirstName.Clear();
            txtTeacherLastName.Clear();
            txtteacherphone.Clear();
            txtteacheremail.Clear();
            txtteacheraddress.Clear();
            txtteachereducational.Clear();

            rbteacherfemale.Checked = false;
            rbteachersingle.Checked = false;
            rbteachermarried.Checked = false;
            rbteacherdivorced.Checked = false;
            rbteacherwidowed.Checked = false;

            dtpteacherDOB.Value = DateTime.Now;
            dtpteachertime.Value = DateTime.Now;

            txtTeacherFirstName.Focus();
        }

        private void btnteacherdelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM teacher WHERE Phone=@phone";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@phone", txtteacherphone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void Inkteacherlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            meinmenu menuForm = new meinmenu();
            menuForm.Show();
            this.Hide();

        }

        private void teachers_registrationform_Load(object sender, EventArgs e)
        {

        }

        private void txtTeacherFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
