namespace application1
{
    partial class teachers_registrationform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTeacherFirstName = new TextBox();
            txtTeacherLastName = new TextBox();
            rbteacherfemale = new RadioButton();
            rbteachermale = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbteachersingle = new RadioButton();
            rbteachermarried = new RadioButton();
            rbteacherdivorced = new RadioButton();
            rbteacherwidowed = new RadioButton();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            dtpteacherDOB = new DateTimePicker();
            groupBox5 = new GroupBox();
            txtteacherphone = new TextBox();
            groupBox6 = new GroupBox();
            txtteacheremail = new TextBox();
            groupBox7 = new GroupBox();
            txtteacheraddress = new RichTextBox();
            groupBox8 = new GroupBox();
            txtteachereducational = new RichTextBox();
            groupBox9 = new GroupBox();
            dtpteachertime = new DateTimePicker();
            Inkteacherlogout = new LinkLabel();
            btnteacherregister = new Button();
            btnteacherupdate = new Button();
            btnteacherdelete = new Button();
            btnteacherclear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(455, 9);
            label1.Name = "label1";
            label1.Size = new Size(444, 46);
            label1.TabIndex = 0;
            label1.Text = "Teacher Registration Form";
            // 
            // txtTeacherFirstName
            // 
            txtTeacherFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeacherFirstName.ForeColor = Color.SaddleBrown;
            txtTeacherFirstName.Location = new Point(21, 41);
            txtTeacherFirstName.Name = "txtTeacherFirstName";
            txtTeacherFirstName.Size = new Size(558, 30);
            txtTeacherFirstName.TabIndex = 2;
            txtTeacherFirstName.Text = "First";
            txtTeacherFirstName.TextChanged += txtTeacherFirstName_TextChanged;
            txtTeacherFirstName.Enter += textBox1_Enter;
            txtTeacherFirstName.Leave += txtTeacherFirstName_Leave;
            // 
            // txtTeacherLastName
            // 
            txtTeacherLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeacherLastName.ForeColor = Color.SaddleBrown;
            txtTeacherLastName.Location = new Point(648, 41);
            txtTeacherLastName.Name = "txtTeacherLastName";
            txtTeacherLastName.Size = new Size(538, 30);
            txtTeacherLastName.TabIndex = 3;
            txtTeacherLastName.Text = "Last";
            txtTeacherLastName.Enter += textTeacherLastName_Enter;
            txtTeacherLastName.Leave += txtTeacherLastName_Leave;
            // 
            // rbteacherfemale
            // 
            rbteacherfemale.AutoSize = true;
            rbteacherfemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbteacherfemale.ForeColor = Color.SaddleBrown;
            rbteacherfemale.Location = new Point(27, 29);
            rbteacherfemale.Name = "rbteacherfemale";
            rbteacherfemale.Size = new Size(85, 27);
            rbteacherfemale.TabIndex = 5;
            rbteacherfemale.TabStop = true;
            rbteacherfemale.Text = "Female";
            rbteacherfemale.UseVisualStyleBackColor = true;
            // 
            // rbteachermale
            // 
            rbteachermale.AutoSize = true;
            rbteachermale.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbteachermale.ForeColor = Color.SaddleBrown;
            rbteachermale.Location = new Point(27, 62);
            rbteachermale.Name = "rbteachermale";
            rbteachermale.Size = new Size(68, 27);
            rbteachermale.TabIndex = 6;
            rbteachermale.TabStop = true;
            rbteachermale.Text = "Male";
            rbteachermale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTeacherLastName);
            groupBox1.Controls.Add(txtTeacherFirstName);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.SaddleBrown;
            groupBox1.Location = new Point(75, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1219, 107);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbteachermale);
            groupBox2.Controls.Add(rbteacherfemale);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.SaddleBrown;
            groupBox2.Location = new Point(75, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1219, 98);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gender";
            // 
            // rbteachersingle
            // 
            rbteachersingle.AutoSize = true;
            rbteachersingle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbteachersingle.Location = new Point(27, 29);
            rbteachersingle.Name = "rbteachersingle";
            rbteachersingle.Size = new Size(77, 27);
            rbteachersingle.TabIndex = 9;
            rbteachersingle.TabStop = true;
            rbteachersingle.Text = "Single";
            rbteachersingle.UseVisualStyleBackColor = true;
            // 
            // rbteachermarried
            // 
            rbteachermarried.AutoSize = true;
            rbteachermarried.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbteachermarried.Location = new Point(363, 29);
            rbteachermarried.Name = "rbteachermarried";
            rbteachermarried.Size = new Size(90, 27);
            rbteachermarried.TabIndex = 10;
            rbteachermarried.TabStop = true;
            rbteachermarried.Text = "Married";
            rbteachermarried.UseVisualStyleBackColor = true;
            // 
            // rbteacherdivorced
            // 
            rbteacherdivorced.AutoSize = true;
            rbteacherdivorced.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbteacherdivorced.Location = new Point(703, 29);
            rbteacherdivorced.Name = "rbteacherdivorced";
            rbteacherdivorced.Size = new Size(98, 27);
            rbteacherdivorced.TabIndex = 11;
            rbteacherdivorced.TabStop = true;
            rbteacherdivorced.Text = "Divorced";
            rbteacherdivorced.UseVisualStyleBackColor = true;
            // 
            // rbteacherwidowed
            // 
            rbteacherwidowed.AutoSize = true;
            rbteacherwidowed.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbteacherwidowed.Location = new Point(1038, 29);
            rbteacherwidowed.Name = "rbteacherwidowed";
            rbteacherwidowed.Size = new Size(102, 27);
            rbteacherwidowed.TabIndex = 12;
            rbteacherwidowed.TabStop = true;
            rbteacherwidowed.Text = "Widowed";
            rbteacherwidowed.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbteacherwidowed);
            groupBox3.Controls.Add(rbteacherdivorced);
            groupBox3.Controls.Add(rbteachermarried);
            groupBox3.Controls.Add(rbteachersingle);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.SaddleBrown;
            groupBox3.Location = new Point(75, 275);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1219, 79);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Marital Status";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpteacherDOB);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.SaddleBrown;
            groupBox4.Location = new Point(75, 360);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1219, 92);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Birthdate";
            // 
            // dtpteacherDOB
            // 
            dtpteacherDOB.Location = new Point(27, 44);
            dtpteacherDOB.Name = "dtpteacherDOB";
            dtpteacherDOB.Size = new Size(322, 30);
            dtpteacherDOB.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtteacherphone);
            groupBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.SaddleBrown;
            groupBox5.Location = new Point(75, 458);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1219, 72);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "Phone";
            // 
            // txtteacherphone
            // 
            txtteacherphone.Location = new Point(27, 29);
            txtteacherphone.Name = "txtteacherphone";
            txtteacherphone.Size = new Size(322, 30);
            txtteacherphone.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtteacheremail);
            groupBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.ForeColor = Color.SaddleBrown;
            groupBox6.Location = new Point(75, 536);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1219, 76);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "Email";
            // 
            // txtteacheremail
            // 
            txtteacheremail.Location = new Point(27, 29);
            txtteacheremail.Name = "txtteacheremail";
            txtteacheremail.Size = new Size(520, 30);
            txtteacheremail.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtteacheraddress);
            groupBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox7.ForeColor = Color.SaddleBrown;
            groupBox7.Location = new Point(75, 618);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1219, 129);
            groupBox7.TabIndex = 17;
            groupBox7.TabStop = false;
            groupBox7.Text = "Address";
            // 
            // txtteacheraddress
            // 
            txtteacheraddress.Location = new Point(27, 29);
            txtteacheraddress.Name = "txtteacheraddress";
            txtteacheraddress.Size = new Size(975, 84);
            txtteacheraddress.TabIndex = 0;
            txtteacheraddress.Text = "";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtteachereducational);
            groupBox8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox8.ForeColor = Color.SaddleBrown;
            groupBox8.Location = new Point(75, 753);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1219, 155);
            groupBox8.TabIndex = 18;
            groupBox8.TabStop = false;
            groupBox8.Text = "Educational Background";
            // 
            // txtteachereducational
            // 
            txtteachereducational.Location = new Point(27, 29);
            txtteachereducational.Name = "txtteachereducational";
            txtteachereducational.Size = new Size(975, 109);
            txtteachereducational.TabIndex = 0;
            txtteachereducational.Text = "";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(dtpteachertime);
            groupBox9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox9.ForeColor = Color.SaddleBrown;
            groupBox9.Location = new Point(75, 914);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(1219, 75);
            groupBox9.TabIndex = 19;
            groupBox9.TabStop = false;
            groupBox9.Text = "Today's Date";
            // 
            // dtpteachertime
            // 
            dtpteachertime.Location = new Point(27, 29);
            dtpteachertime.Name = "dtpteachertime";
            dtpteachertime.Size = new Size(322, 30);
            dtpteachertime.TabIndex = 0;
            // 
            // Inkteacherlogout
            // 
            Inkteacherlogout.AutoSize = true;
            Inkteacherlogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inkteacherlogout.Location = new Point(12, 29);
            Inkteacherlogout.Name = "Inkteacherlogout";
            Inkteacherlogout.Size = new Size(67, 23);
            Inkteacherlogout.TabIndex = 20;
            Inkteacherlogout.TabStop = true;
            Inkteacherlogout.Text = "Logout";
            Inkteacherlogout.LinkClicked += Inkteacherlogout_LinkClicked;
            // 
            // btnteacherregister
            // 
            btnteacherregister.BackColor = Color.YellowGreen;
            btnteacherregister.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnteacherregister.Location = new Point(75, 995);
            btnteacherregister.Name = "btnteacherregister";
            btnteacherregister.Size = new Size(85, 42);
            btnteacherregister.TabIndex = 21;
            btnteacherregister.Text = "Register";
            btnteacherregister.UseVisualStyleBackColor = false;
            btnteacherregister.Click += btnteacherregister_Click;
            // 
            // btnteacherupdate
            // 
            btnteacherupdate.BackColor = Color.YellowGreen;
            btnteacherupdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnteacherupdate.Location = new Point(230, 995);
            btnteacherupdate.Name = "btnteacherupdate";
            btnteacherupdate.Size = new Size(85, 42);
            btnteacherupdate.TabIndex = 22;
            btnteacherupdate.Text = "Update";
            btnteacherupdate.UseVisualStyleBackColor = false;
            btnteacherupdate.Click += btnteacherupdate_Click;
            // 
            // btnteacherdelete
            // 
            btnteacherdelete.BackColor = Color.Red;
            btnteacherdelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnteacherdelete.Location = new Point(1209, 995);
            btnteacherdelete.Name = "btnteacherdelete";
            btnteacherdelete.Size = new Size(85, 42);
            btnteacherdelete.TabIndex = 23;
            btnteacherdelete.Text = "Delete";
            btnteacherdelete.UseVisualStyleBackColor = false;
            btnteacherdelete.Click += btnteacherdelete_Click;
            // 
            // btnteacherclear
            // 
            btnteacherclear.BackColor = Color.Red;
            btnteacherclear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnteacherclear.Location = new Point(1049, 995);
            btnteacherclear.Name = "btnteacherclear";
            btnteacherclear.Size = new Size(85, 42);
            btnteacherclear.TabIndex = 24;
            btnteacherclear.Text = "Clear";
            btnteacherclear.UseVisualStyleBackColor = false;
            btnteacherclear.Click += btnteacherclear_Click;
            // 
            // teachers_registrationform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1355, 1055);
            Controls.Add(btnteacherclear);
            Controls.Add(btnteacherdelete);
            Controls.Add(btnteacherupdate);
            Controls.Add(btnteacherregister);
            Controls.Add(Inkteacherlogout);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "teachers_registrationform";
            Text = "teachers_registrationform";
            Load += teachers_registrationform_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTeacherFirstName;
        private TextBox txtTeacherLastName;
        private RadioButton rbteacherfemale;
        private RadioButton rbteachermale;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbteachersingle;
        private RadioButton rbteachermarried;
        private RadioButton rbteacherdivorced;
        private RadioButton rbteacherwidowed;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DateTimePicker dtpteacherDOB;
        private GroupBox groupBox5;
        private TextBox txtteacherphone;
        private GroupBox groupBox6;
        private TextBox txtteacheremail;
        private GroupBox groupBox7;
        private RichTextBox txtteacheraddress;
        private GroupBox groupBox8;
        private RichTextBox txtteachereducational;
        private GroupBox groupBox9;
        private DateTimePicker dtpteachertime;
        private LinkLabel Inkteacherlogout;
        private Button btnteacherregister;
        private Button btnteacherupdate;
        private Button btnteacherdelete;
        private Button btnteacherclear;
    }
}