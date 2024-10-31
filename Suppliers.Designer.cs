namespace inventory_management_app
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            pnlProduct = new Panel();
            pnlEdit = new Panel();
            txtAddressEdit = new TextBox();
            txtEmailEdit = new TextBox();
            mtxtPhoneEdit = new MaskedTextBox();
            btnSaveEdit = new Button();
            btnCancelEdit = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNameEdit = new TextBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            pnlAdd = new Panel();
            txtAddress = new TextBox();
            txtMail = new TextBox();
            mtxtPhone = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            picAdd = new PictureBox();
            btnAdd = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            pnlProduct.SuspendLayout();
            pnlEdit.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlAdd.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlProduct
            // 
            pnlProduct.BackColor = Color.WhiteSmoke;
            pnlProduct.Controls.Add(pnlEdit);
            pnlProduct.Controls.Add(pnlAdd);
            pnlProduct.Controls.Add(picAdd);
            pnlProduct.Controls.Add(btnAdd);
            pnlProduct.Controls.Add(pictureBox3);
            pnlProduct.Controls.Add(label1);
            pnlProduct.Controls.Add(txtSearch);
            pnlProduct.Controls.Add(panel2);
            pnlProduct.Controls.Add(dataGridView1);
            pnlProduct.Location = new Point(0, 0);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new Size(1130, 723);
            pnlProduct.TabIndex = 11;
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(txtAddressEdit);
            pnlEdit.Controls.Add(txtEmailEdit);
            pnlEdit.Controls.Add(mtxtPhoneEdit);
            pnlEdit.Controls.Add(btnSaveEdit);
            pnlEdit.Controls.Add(btnCancelEdit);
            pnlEdit.Controls.Add(label7);
            pnlEdit.Controls.Add(label8);
            pnlEdit.Controls.Add(label9);
            pnlEdit.Controls.Add(label10);
            pnlEdit.Controls.Add(txtNameEdit);
            pnlEdit.Controls.Add(panel4);
            pnlEdit.Location = new Point(115, 146);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(900, 430);
            pnlEdit.TabIndex = 38;
            // 
            // txtAddressEdit
            // 
            txtAddressEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddressEdit.ForeColor = Color.FromArgb(9, 20, 64);
            txtAddressEdit.Location = new Point(585, 216);
            txtAddressEdit.Multiline = true;
            txtAddressEdit.Name = "txtAddressEdit";
            txtAddressEdit.Size = new Size(230, 90);
            txtAddressEdit.TabIndex = 36;
            txtAddressEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailEdit
            // 
            txtEmailEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailEdit.ForeColor = Color.FromArgb(9, 20, 64);
            txtEmailEdit.Location = new Point(174, 216);
            txtEmailEdit.Name = "txtEmailEdit";
            txtEmailEdit.Size = new Size(230, 43);
            txtEmailEdit.TabIndex = 35;
            txtEmailEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // mtxtPhoneEdit
            // 
            mtxtPhoneEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtPhoneEdit.ForeColor = Color.FromArgb(9, 20, 64);
            mtxtPhoneEdit.Location = new Point(585, 132);
            mtxtPhoneEdit.Mask = "(999) 000-0000";
            mtxtPhoneEdit.Name = "mtxtPhoneEdit";
            mtxtPhoneEdit.Size = new Size(230, 43);
            mtxtPhoneEdit.TabIndex = 34;
            mtxtPhoneEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.BackColor = Color.FromArgb(12, 27, 83);
            btnSaveEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = Color.WhiteSmoke;
            btnSaveEdit.Location = new Point(40, 350);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Padding = new Padding(5);
            btnSaveEdit.Size = new Size(150, 50);
            btnSaveEdit.TabIndex = 33;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.FromArgb(12, 27, 83);
            btnCancelEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelEdit.ForeColor = Color.WhiteSmoke;
            btnCancelEdit.Location = new Point(211, 350);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Padding = new Padding(5);
            btnCancelEdit.Size = new Size(150, 50);
            btnCancelEdit.TabIndex = 32;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(4, 12, 41);
            label7.Location = new Point(452, 219);
            label7.Name = "label7";
            label7.Size = new Size(120, 37);
            label7.TabIndex = 25;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(4, 12, 41);
            label8.Location = new Point(40, 219);
            label8.Name = "label8";
            label8.Size = new Size(87, 37);
            label8.TabIndex = 24;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(4, 12, 41);
            label9.Location = new Point(452, 138);
            label9.Name = "label9";
            label9.Size = new Size(98, 37);
            label9.TabIndex = 23;
            label9.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(4, 12, 41);
            label10.Location = new Point(40, 138);
            label10.Name = "label10";
            label10.Size = new Size(93, 37);
            label10.TabIndex = 22;
            label10.Text = "Name";
            // 
            // txtNameEdit
            // 
            txtNameEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameEdit.ForeColor = Color.FromArgb(9, 20, 64);
            txtNameEdit.Location = new Point(174, 135);
            txtNameEdit.Name = "txtNameEdit";
            txtNameEdit.Size = new Size(230, 43);
            txtNameEdit.TabIndex = 3;
            txtNameEdit.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(9, 20, 64);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(900, 95);
            panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(9, 20, 64);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(76, 35);
            label11.Name = "label11";
            label11.Size = new Size(181, 37);
            label11.TabIndex = 12;
            label11.Text = "Edit Supplier";
            // 
            // pnlAdd
            // 
            pnlAdd.Controls.Add(txtAddress);
            pnlAdd.Controls.Add(txtMail);
            pnlAdd.Controls.Add(mtxtPhone);
            pnlAdd.Controls.Add(btnSave);
            pnlAdd.Controls.Add(btnCancel);
            pnlAdd.Controls.Add(label6);
            pnlAdd.Controls.Add(label5);
            pnlAdd.Controls.Add(label4);
            pnlAdd.Controls.Add(label3);
            pnlAdd.Controls.Add(txtName);
            pnlAdd.Controls.Add(panel3);
            pnlAdd.Location = new Point(115, 150);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(900, 430);
            pnlAdd.TabIndex = 22;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.FromArgb(9, 20, 64);
            txtAddress.Location = new Point(585, 216);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(230, 90);
            txtAddress.TabIndex = 36;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.ForeColor = Color.FromArgb(9, 20, 64);
            txtMail.Location = new Point(174, 216);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(230, 43);
            txtMail.TabIndex = 35;
            txtMail.TextAlign = HorizontalAlignment.Center;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            mtxtPhone.ForeColor = Color.FromArgb(9, 20, 64);
            mtxtPhone.Location = new Point(585, 132);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(230, 43);
            mtxtPhone.TabIndex = 34;
            mtxtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(12, 27, 83);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(40, 350);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(5);
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(12, 27, 83);
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(211, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(4, 12, 41);
            label6.Location = new Point(452, 219);
            label6.Name = "label6";
            label6.Size = new Size(120, 37);
            label6.TabIndex = 25;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(4, 12, 41);
            label5.Location = new Point(40, 219);
            label5.Name = "label5";
            label5.Size = new Size(87, 37);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(4, 12, 41);
            label4.Location = new Point(452, 138);
            label4.Name = "label4";
            label4.Size = new Size(98, 37);
            label4.TabIndex = 23;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(4, 12, 41);
            label3.Location = new Point(40, 138);
            label3.Name = "label3";
            label3.Size = new Size(93, 37);
            label3.TabIndex = 22;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(9, 20, 64);
            txtName.Location = new Point(174, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 43);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(9, 20, 64);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 95);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(9, 20, 64);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(76, 35);
            label2.Name = "label2";
            label2.Size = new Size(184, 37);
            label2.TabIndex = 12;
            label2.Text = "Add Supplier";
            // 
            // picAdd
            // 
            picAdd.BackColor = Color.FromArgb(9, 20, 64);
            picAdd.Image = (Image)resources.GetObject("picAdd.Image");
            picAdd.Location = new Point(962, 105);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(27, 27);
            picAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdd.TabIndex = 16;
            picAdd.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(9, 20, 64);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.ImageAlign = ContentAlignment.TopLeft;
            btnAdd.Location = new Point(941, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(30, 0, 0, 0);
            btnAdd.Size = new Size(160, 37);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(326, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(4, 12, 41);
            label1.Location = new Point(30, 100);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 11;
            label1.Text = "Suppliers";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Silver;
            txtSearch.Location = new Point(30, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(330, 39);
            txtSearch.TabIndex = 10;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 44, 67);
            panel2.Location = new Point(30, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 1);
            panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1070, 534);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1130, 723);
            Controls.Add(pnlProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Suppliers";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Suppliers";
            Load += Suppliers_Load;
            pnlProduct.ResumeLayout(false);
            pnlProduct.PerformLayout();
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlAdd.ResumeLayout(false);
            pnlAdd.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProduct;
        private PictureBox picAdd;
        private Button btnAdd;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox txtSearch;
        private Panel panel2;
        private Panel pnlAdd;
        private Button btnSave;
        private Button btnCancel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtAddress;
        private TextBox txtMail;
        private MaskedTextBox mtxtPhone;
        private DataGridView dataGridView1;
        private Panel pnlEdit;
        private TextBox txtAddressEdit;
        private TextBox txtEmailEdit;
        private MaskedTextBox mtxtPhoneEdit;
        private Button btnSaveEdit;
        private Button btnCancelEdit;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNameEdit;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label11;
    }
}