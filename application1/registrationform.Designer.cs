namespace application1
{
    partial class registrationform
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
            InkLogout = new LinkLabel();
            groupBox1 = new GroupBox();
            InkExit = new LinkLabel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            groupBox4 = new GroupBox();
            txtContact = new TextBox();
            txtNIC = new TextBox();
            txtParent = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            txtHome = new TextBox();
            label10 = new Label();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dtpDOB = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmdRegNo = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(521, 9);
            label1.Name = "label1";
            label1.Size = new Size(498, 46);
            label1.TabIndex = 0;
            label1.Text = "Campus One Digital Academy";
            // 
            // InkLogout
            // 
            InkLogout.AutoSize = true;
            InkLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InkLogout.Location = new Point(12, 9);
            InkLogout.Name = "InkLogout";
            InkLogout.Size = new Size(67, 23);
            InkLogout.TabIndex = 1;
            InkLogout.TabStop = true;
            InkLogout.Text = "Logout";
            InkLogout.LinkClicked += InkLogout_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InkExit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cmdRegNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1429, 954);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // InkExit
            // 
            InkExit.AutoSize = true;
            InkExit.Location = new Point(1359, 973);
            InkExit.Name = "InkExit";
            InkExit.Size = new Size(40, 23);
            InkExit.TabIndex = 9;
            InkExit.TabStop = true;
            InkExit.Text = "Exit";
            InkExit.LinkClicked += InkExit_LinkClicked;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Location = new Point(1160, 898);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 49);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(1295, 898);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 49);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.GreenYellow;
            btnUpdate.Location = new Point(171, 898);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 49);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.GreenYellow;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(24, 898);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(104, 49);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtContact);
            groupBox4.Controls.Add(txtNIC);
            groupBox4.Controls.Add(txtParent);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(23, 642);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1376, 250);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Perent Details";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(184, 170);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(335, 30);
            txtContact.TabIndex = 5;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(184, 108);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(335, 30);
            txtNIC.TabIndex = 4;
            // 
            // txtParent
            // 
            txtParent.Location = new Point(184, 39);
            txtParent.Name = "txtParent";
            txtParent.Size = new Size(1057, 30);
            txtParent.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(35, 177);
            label13.Name = "label13";
            label13.Size = new Size(138, 23);
            label13.TabIndex = 2;
            label13.Text = "Contact Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(35, 115);
            label12.Name = "label12";
            label12.Size = new Size(39, 23);
            label12.TabIndex = 1;
            label12.Text = "NIC";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(35, 46);
            label11.Name = "label11";
            label11.Size = new Size(110, 23);
            label11.TabIndex = 0;
            label11.Text = "Perent Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtHome);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtMobile);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(23, 361);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1376, 275);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // txtHome
            // 
            txtHome.Location = new Point(841, 215);
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(400, 30);
            txtHome.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(676, 222);
            label10.Name = "label10";
            label10.Size = new Size(110, 23);
            label10.TabIndex = 6;
            label10.Text = "Home Phone";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(184, 215);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(335, 30);
            txtMobile.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1057, 30);
            txtEmail.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(184, 29);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(1057, 81);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 222);
            label9.Name = "label9";
            label9.Size = new Size(116, 23);
            label9.TabIndex = 2;
            label9.Text = "Mobile Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 151);
            label8.Name = "label8";
            label8.Size = new Size(51, 23);
            label8.TabIndex = 1;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 87);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 0;
            label7.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbFemale);
            groupBox2.Controls.Add(rbMale);
            groupBox2.Controls.Add(dtpDOB);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(23, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1376, 277);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(402, 224);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(85, 27);
            rbFemale.TabIndex = 8;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(184, 224);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(68, 27);
            rbMale.TabIndex = 7;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(184, 161);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(303, 30);
            dtpDOB.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(184, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(678, 30);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(184, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(678, 30);
            txtFirstName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 228);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 3;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 168);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 2;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 101);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 1;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 43);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 0;
            label3.Text = "First Name";
            // 
            // cmdRegNo
            // 
            cmdRegNo.FormattingEnabled = true;
            cmdRegNo.Location = new Point(207, 30);
            cmdRegNo.Name = "cmdRegNo";
            cmdRegNo.Size = new Size(383, 31);
            cmdRegNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 38);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 0;
            label2.Text = "Reg No";
            // 
            // registrationform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1453, 1024);
            Controls.Add(groupBox1);
            Controls.Add(InkLogout);
            Controls.Add(label1);
            Name = "registrationform";
            Text = "registrationform";
            Load += registrationform_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel InkLogout;
        private GroupBox groupBox1;
        private ComboBox cmdRegNo;
        private Label label2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox txtHome;
        private Label label10;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private RichTextBox txtAddress;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRegister;
        private TextBox txtContact;
        private TextBox txtNIC;
        private TextBox txtParent;
        private Label label13;
        private Label label12;
        private Label label11;
        private LinkLabel InkExit;
        private GroupBox groupBox2;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private DateTimePicker dtpDOB;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}