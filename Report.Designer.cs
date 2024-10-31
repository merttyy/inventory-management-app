namespace inventory_management_app
{
    partial class Report
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
            pnlReport = new Panel();
            pnlSort1 = new Panel();
            linkNumOfItems = new LinkLabel();
            linkName = new LinkLabel();
            linkID = new LinkLabel();
            btnSort = new Button();
            btnBack = new Button();
            btnNext = new Button();
            label3 = new Label();
            btnCancel = new Button();
            btnPrint = new Button();
            pnlPrint = new Panel();
            pnlPriceList = new Panel();
            label2 = new Label();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            pnlReport.SuspendLayout();
            pnlSort1.SuspendLayout();
            pnlPrint.SuspendLayout();
            pnlPriceList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReport
            // 
            pnlReport.Controls.Add(pnlSort1);
            pnlReport.Controls.Add(btnSort);
            pnlReport.Controls.Add(btnBack);
            pnlReport.Controls.Add(btnNext);
            pnlReport.Controls.Add(label3);
            pnlReport.Controls.Add(btnCancel);
            pnlReport.Controls.Add(btnPrint);
            pnlReport.Controls.Add(pnlPrint);
            pnlReport.Location = new Point(0, 0);
            pnlReport.Name = "pnlReport";
            pnlReport.Size = new Size(1130, 723);
            pnlReport.TabIndex = 0;
            // 
            // pnlSort1
            // 
            pnlSort1.BackColor = Color.FromArgb(12, 27, 83);
            pnlSort1.Controls.Add(linkNumOfItems);
            pnlSort1.Controls.Add(linkName);
            pnlSort1.Controls.Add(linkID);
            pnlSort1.Location = new Point(502, 20);
            pnlSort1.Name = "pnlSort1";
            pnlSort1.Size = new Size(455, 46);
            pnlSort1.TabIndex = 42;
            // 
            // linkNumOfItems
            // 
            linkNumOfItems.AutoSize = true;
            linkNumOfItems.LinkColor = Color.White;
            linkNumOfItems.Location = new Point(219, 8);
            linkNumOfItems.Name = "linkNumOfItems";
            linkNumOfItems.Size = new Size(233, 32);
            linkNumOfItems.TabIndex = 2;
            linkNumOfItems.TabStop = true;
            linkNumOfItems.Text = "by Number Of Items";
            linkNumOfItems.LinkClicked += linkNumOfItems_LinkClicked;
            // 
            // linkName
            // 
            linkName.AutoSize = true;
            linkName.LinkColor = Color.White;
            linkName.Location = new Point(97, 8);
            linkName.Name = "linkName";
            linkName.Size = new Size(111, 32);
            linkName.TabIndex = 1;
            linkName.TabStop = true;
            linkName.Text = "by Name";
            linkName.LinkClicked += linkName_LinkClicked;
            // 
            // linkID
            // 
            linkID.AutoSize = true;
            linkID.LinkColor = Color.White;
            linkID.Location = new Point(11, 9);
            linkID.Name = "linkID";
            linkID.Size = new Size(70, 32);
            linkID.TabIndex = 0;
            linkID.TabStop = true;
            linkID.Text = "by ID";
            linkID.LinkClicked += linkID_LinkClicked;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(12, 27, 83);
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSort.ForeColor = Color.WhiteSmoke;
            btnSort.Location = new Point(954, 18);
            btnSort.Name = "btnSort";
            btnSort.Padding = new Padding(5);
            btnSort.Size = new Size(150, 50);
            btnSort.TabIndex = 41;
            btnSort.Text = "Sort by";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(12, 27, 83);
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.WhiteSmoke;
            btnBack.Location = new Point(465, 661);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(5);
            btnBack.Size = new Size(50, 50);
            btnBack.TabIndex = 40;
            btnBack.Text = "⏪";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(12, 27, 83);
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.WhiteSmoke;
            btnNext.Location = new Point(590, 661);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(5);
            btnNext.Size = new Size(50, 50);
            btnNext.TabIndex = 39;
            btnNext.Text = "⏩";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 670);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 38;
            label3.Text = "1 / 2";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(12, 27, 83);
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(954, 661);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(5);
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(12, 27, 83);
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.WhiteSmoke;
            btnPrint.Location = new Point(23, 661);
            btnPrint.Name = "btnPrint";
            btnPrint.Padding = new Padding(5);
            btnPrint.Size = new Size(150, 50);
            btnPrint.TabIndex = 34;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // pnlPrint
            // 
            pnlPrint.BackColor = Color.White;
            pnlPrint.Controls.Add(pnlPriceList);
            pnlPrint.Controls.Add(label1);
            pnlPrint.Controls.Add(listView1);
            pnlPrint.Location = new Point(23, 90);
            pnlPrint.Name = "pnlPrint";
            pnlPrint.Size = new Size(1081, 565);
            pnlPrint.TabIndex = 36;
            // 
            // pnlPriceList
            // 
            pnlPriceList.BackColor = Color.White;
            pnlPriceList.Controls.Add(label2);
            pnlPriceList.Controls.Add(listView2);
            pnlPriceList.Location = new Point(0, 0);
            pnlPriceList.Name = "pnlPriceList";
            pnlPriceList.Size = new Size(1081, 631);
            pnlPriceList.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(4, 12, 41);
            label2.Location = new Point(435, 8);
            label2.Name = "label2";
            label2.Size = new Size(180, 45);
            label2.TabIndex = 12;
            label2.Text = "PRICE LIST";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(0, 60);
            listView2.Name = "listView2";
            listView2.Size = new Size(1081, 571);
            listView2.TabIndex = 13;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Product Name";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 460;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Unit Price";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 460;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(4, 12, 41);
            label1.Location = new Point(404, 8);
            label1.Name = "label1";
            label1.Size = new Size(251, 45);
            label1.TabIndex = 12;
            label1.Text = "STOCK REPORT";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(0, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(1081, 571);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Product Category";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 460;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Number Of Items";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 460;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1130, 723);
            Controls.Add(pnlReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Report";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Report";
            Load += Report_Load;
            pnlReport.ResumeLayout(false);
            pnlReport.PerformLayout();
            pnlSort1.ResumeLayout(false);
            pnlSort1.PerformLayout();
            pnlPrint.ResumeLayout(false);
            pnlPrint.PerformLayout();
            pnlPriceList.ResumeLayout(false);
            pnlPriceList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReport;
        private Label label1;
        private ListView listView1;
        private Button btnCancel;
        private Button btnPrint;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel pnlPrint;
        private Panel pnlPriceList;
        private Label label2;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnBack;
        private Button btnNext;
        private Label label3;
        private Panel pnlSort1;
        private LinkLabel linkNumOfItems;
        private LinkLabel linkName;
        private LinkLabel linkID;
        private Button btnSort;
    }
}