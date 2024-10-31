namespace inventory_management_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            pnlReset = new Panel();
            btnCancelPas = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnResetPass = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            lnkReset = new LinkLabel();
            picUnlocked = new PictureBox();
            picLocked = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            pnlReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUnlocked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLocked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(4, 12, 41);
            label1.Location = new Point(997, 168);
            label1.Name = "label1";
            label1.Size = new Size(205, 45);
            label1.TabIndex = 0;
            label1.Text = "USER LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pnlReset);
            panel1.Controls.Add(lnkReset);
            panel1.Controls.Add(picUnlocked);
            panel1.Controls.Add(picLocked);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(75, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1339, 649);
            panel1.TabIndex = 1;
            // 
            // pnlReset
            // 
            pnlReset.BackColor = Color.WhiteSmoke;
            pnlReset.Controls.Add(btnCancelPas);
            pnlReset.Controls.Add(label6);
            pnlReset.Controls.Add(textBox3);
            pnlReset.Controls.Add(label8);
            pnlReset.Controls.Add(label9);
            pnlReset.Controls.Add(btnResetPass);
            pnlReset.Controls.Add(textBox1);
            pnlReset.Controls.Add(textBox2);
            pnlReset.Controls.Add(label10);
            pnlReset.ForeColor = Color.FromArgb(224, 224, 224);
            pnlReset.Location = new Point(850, 0);
            pnlReset.Name = "pnlReset";
            pnlReset.Size = new Size(489, 649);
            pnlReset.TabIndex = 12;
            // 
            // btnCancelPas
            // 
            btnCancelPas.BackColor = Color.FromArgb(12, 27, 83);
            btnCancelPas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelPas.ForeColor = Color.WhiteSmoke;
            btnCancelPas.Location = new Point(249, 499);
            btnCancelPas.Name = "btnCancelPas";
            btnCancelPas.Padding = new Padding(5);
            btnCancelPas.Size = new Size(180, 60);
            btnCancelPas.TabIndex = 9;
            btnCancelPas.Text = "CANCEL";
            btnCancelPas.UseVisualStyleBackColor = false;
            btnCancelPas.Click += btnCancelPas_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(9, 20, 64);
            label6.Location = new Point(68, 380);
            label6.Name = "label6";
            label6.Size = new Size(228, 37);
            label6.TabIndex = 8;
            label6.Text = "Password (Again)";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(9, 20, 64);
            textBox3.Location = new Point(68, 424);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(276, 43);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(9, 20, 64);
            label8.Location = new Point(68, 281);
            label8.Name = "label8";
            label8.Size = new Size(132, 37);
            label8.TabIndex = 6;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(9, 20, 64);
            label9.Location = new Point(68, 167);
            label9.Name = "label9";
            label9.Size = new Size(140, 37);
            label9.TabIndex = 5;
            label9.Text = "Username";
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = Color.FromArgb(12, 27, 83);
            btnResetPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetPass.ForeColor = Color.WhiteSmoke;
            btnResetPass.Location = new Point(53, 499);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Padding = new Padding(5);
            btnResetPass.Size = new Size(180, 60);
            btnResetPass.TabIndex = 4;
            btnResetPass.Text = "SAVE";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(9, 20, 64);
            textBox1.Location = new Point(68, 325);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(276, 43);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(9, 20, 64);
            textBox2.Location = new Point(68, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 43);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(4, 12, 41);
            label10.Location = new Point(53, 103);
            label10.Name = "label10";
            label10.Size = new Size(394, 45);
            label10.TabIndex = 0;
            label10.Text = "RESET YOUR PASSWORD";
            // 
            // lnkReset
            // 
            lnkReset.ActiveLinkColor = Color.FromArgb(12, 27, 83);
            lnkReset.AutoSize = true;
            lnkReset.Font = new Font("Segoe UI Semibold", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            lnkReset.LinkColor = Color.FromArgb(12, 27, 83);
            lnkReset.Location = new Point(1021, 605);
            lnkReset.Name = "lnkReset";
            lnkReset.Size = new Size(160, 30);
            lnkReset.TabIndex = 11;
            lnkReset.TabStop = true;
            lnkReset.Text = "Reset Password";
            lnkReset.VisitedLinkColor = Color.FromArgb(12, 27, 83);
            lnkReset.LinkClicked += lnkReset_LinkClicked;
            // 
            // picUnlocked
            // 
            picUnlocked.Image = (Image)resources.GetObject("picUnlocked.Image");
            picUnlocked.Location = new Point(1059, 83);
            picUnlocked.Name = "picUnlocked";
            picUnlocked.Size = new Size(65, 65);
            picUnlocked.SizeMode = PictureBoxSizeMode.StretchImage;
            picUnlocked.TabIndex = 10;
            picUnlocked.TabStop = false;
            // 
            // picLocked
            // 
            picLocked.Image = (Image)resources.GetObject("picLocked.Image");
            picLocked.Location = new Point(1059, 83);
            picLocked.Name = "picLocked";
            picLocked.Size = new Size(65, 65);
            picLocked.SizeMode = PictureBoxSizeMode.StretchImage;
            picLocked.TabIndex = 9;
            picLocked.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.Gray;
            label5.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(94, 259);
            label5.Name = "label5";
            label5.Size = new Size(690, 189);
            label5.TabIndex = 8;
            label5.Text = "Discover the go-to solution for effortless stock control. Manage your products and stay informed with updates about your inventory. Transform the way you handle stock management.";
            // 
            // label4
            // 
            label4.BackColor = Color.Gray;
            label4.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(94, 109);
            label4.Name = "label4";
            label4.Size = new Size(690, 129);
            label4.TabIndex = 7;
            label4.Text = "Welcome Back To\r\nInventory Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(9, 20, 64);
            label3.Location = new Point(962, 380);
            label3.Name = "label3";
            label3.Size = new Size(132, 37);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(9, 20, 64);
            label2.Location = new Point(962, 261);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 27, 83);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(1004, 529);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(198, 68);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(9, 20, 64);
            txtPassword.Location = new Point(962, 424);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(276, 43);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(9, 20, 64);
            txtUsername.Location = new Point(962, 310);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(276, 43);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(865, 685);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(45, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 50);
            panel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(301, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 200);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 20, 64);
            ClientSize = new Size(1485, 775);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(241, 246, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlReset.ResumeLayout(false);
            pnlReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUnlocked).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLocked).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox picLocked;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox picUnlocked;
        private LinkLabel lnkReset;
        private Panel pnlReset;
        private Button btnCancelPas;
        private Label label6;
        private TextBox textBox3;
        private Label label8;
        private Label label9;
        private Button btnResetPass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label10;
    }
}