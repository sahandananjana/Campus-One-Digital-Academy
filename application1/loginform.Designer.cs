namespace application1
{
    partial class loginform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnlogin = new Button();
            btnclear = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            lblpassword = new Label();
            lblusername = new Label();
            btnexit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Controls.Add(btnclear);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Controls.Add(lblpassword);
            groupBox1.Controls.Add(lblusername);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(831, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 508);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(183, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.GreenYellow;
            btnlogin.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(373, 434);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(106, 47);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Yellow;
            btnclear.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(68, 434);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(106, 47);
            btnclear.TabIndex = 4;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(183, 362);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(296, 30);
            txtpassword.TabIndex = 3;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(183, 275);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(296, 30);
            txtusername.TabIndex = 2;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.ForeColor = Color.Black;
            lblpassword.Location = new Point(73, 369);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(87, 19);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.Black;
            lblusername.Location = new Point(68, 282);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(88, 19);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username";
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Red;
            btnexit.Font = new Font("Impact", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(45, 767);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(106, 47);
            btnexit.TabIndex = 2;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1558, 826);
            Controls.Add(btnexit);
            Controls.Add(groupBox1);
            Name = "loginform";
            Text = "Form1";
            Load += loginform_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnlogin;
        private Button btnclear;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label lblpassword;
        private Label lblusername;
        private Button btnexit;
        private PictureBox pictureBox1;
    }
}
