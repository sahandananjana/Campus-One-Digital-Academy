namespace application1
{
    partial class File_Form
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
            pictureBox1 = new PictureBox();
            btnFileLogOut = new Button();
            btnFileMainMenu = new Button();
            btnExitSystem = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(722, 69);
            label1.Name = "label1";
            label1.Size = new Size(170, 46);
            label1.TabIndex = 0;
            label1.Text = "FIle Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__1_1;
            pictureBox1.Location = new Point(378, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnFileLogOut
            // 
            btnFileLogOut.BackColor = Color.Red;
            btnFileLogOut.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFileLogOut.ForeColor = Color.White;
            btnFileLogOut.Location = new Point(1013, 195);
            btnFileLogOut.Name = "btnFileLogOut";
            btnFileLogOut.Size = new Size(227, 64);
            btnFileLogOut.TabIndex = 5;
            btnFileLogOut.Text = "Log Out";
            btnFileLogOut.UseVisualStyleBackColor = false;
            btnFileLogOut.Click += btnFileLogOut_Click;
            // 
            // btnFileMainMenu
            // 
            btnFileMainMenu.BackColor = Color.Red;
            btnFileMainMenu.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFileMainMenu.ForeColor = Color.White;
            btnFileMainMenu.Location = new Point(1013, 343);
            btnFileMainMenu.Name = "btnFileMainMenu";
            btnFileMainMenu.Size = new Size(227, 64);
            btnFileMainMenu.TabIndex = 6;
            btnFileMainMenu.Text = "Back to Main Menu";
            btnFileMainMenu.UseVisualStyleBackColor = false;
            btnFileMainMenu.Click += btnFileMainMenu_Click;
            // 
            // btnExitSystem
            // 
            btnExitSystem.BackColor = Color.Red;
            btnExitSystem.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExitSystem.ForeColor = Color.White;
            btnExitSystem.Location = new Point(1013, 496);
            btnExitSystem.Name = "btnExitSystem";
            btnExitSystem.Size = new Size(227, 64);
            btnExitSystem.TabIndex = 7;
            btnExitSystem.Text = "Exit System";
            btnExitSystem.UseVisualStyleBackColor = false;
            btnExitSystem.Click += btnExitSystem_Click;
            // 
            // File_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Campus_Theme_Background__2_;
            ClientSize = new Size(1573, 819);
            Controls.Add(btnExitSystem);
            Controls.Add(btnFileMainMenu);
            Controls.Add(btnFileLogOut);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "File_Form";
            Text = "File_Form";
            Load += File_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnFileLogOut;
        private Button btnFileMainMenu;
        private Button btnExitSystem;
    }
}