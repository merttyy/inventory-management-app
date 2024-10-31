using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_app
{
    public partial class Report : Form
    {
        PrintPreviewDialog printPrewD = new PrintPreviewDialog();
        PrintDocument pntDoc = new PrintDocument();
        public Report()
        {
            InitializeComponent();
        }

        // Print panel
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            pnlPrint = pnl;
            getPrintArea(pnl);
            printPrewD.Document = pntDoc;
            pntDoc.PrintPage += new PrintPageEventHandler(pntDoc_printpage);
            printPrewD.ShowDialog();
        }

        // Locate panel in page
        private void pntDoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            int printAreaWidth = Math.Min(pageArea.Width, this.pnlPrint.Width);
            int printAreaHeight = Math.Min(pageArea.Height, this.pnlPrint.Height);

            // Calculate the scale factors for width and height
            float scaleX = (float)printAreaWidth / this.pnlPrint.Width;
            float scaleY = (float)printAreaHeight / this.pnlPrint.Height;

            // Use the minimum scale factor to maintain the aspect ratio
            float scale = Math.Min(scaleX, scaleY);

            // Calculate the centered position
            int x = (int)((pageArea.Width - this.pnlPrint.Width * scale) / 2);

            // Draw the scaled and positioned image
            e.Graphics.DrawImage(bmp, new Rectangle(x, 0, (int)(this.pnlPrint.Width * scale), (int)(this.pnlPrint.Height * scale)));
        }

        Bitmap bmp;
        private void getPrintArea(Panel pnl)
        {
            bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        SqlConnection connRep = new SqlConnection(@"Data Source=DESKTOP-I4CJIKK;Initial Catalog=InventoryManagement;Integrated Security=True");
        
        // List stock report
        private void listReport()
        {
            listView1.Items.Clear();
            connRep.Open();
            SqlCommand cmdRep = new SqlCommand("SELECT * FROM category", connRep);
            SqlDataReader drRep = cmdRep.ExecuteReader();

            while (drRep.Read())
            {
                ListViewItem addRep = new ListViewItem();

                addRep.Text = drRep["category_id"].ToString();
                addRep.SubItems.Add(drRep["name"].ToString());
                addRep.SubItems.Add(drRep["number_of_items"].ToString());


                listView1.Items.Add(addRep);

            }
            connRep.Close();
        }

        // List price report
        private void listPriceReport()
        {
            listView2.Items.Clear();
            connRep.Open();
            SqlCommand cmdRep = new SqlCommand("SELECT * FROM product", connRep);
            SqlDataReader drRep = cmdRep.ExecuteReader();

            while (drRep.Read())
            {
                ListViewItem addRep = new ListViewItem();

                addRep.Text = drRep["product_id"].ToString();
                addRep.SubItems.Add(drRep["name"].ToString());
                addRep.SubItems.Add(drRep["unit_price"].ToString() + " $");


                listView2.Items.Add(addRep);

            }
            connRep.Close();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(867, 417);
            listReport();
            pnlPriceList.Visible = false;
            pnlSort1.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (label3.Text == "1 / 2")
            {
                Print(this.pnlPrint);
            }
            else
            {
                Print(this.pnlPriceList);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlPriceList.Visible = true;
            label3.Text = "2 / 2";
            linkNumOfItems.Text = "by Price";
            listPriceReport();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPriceList.Visible = false;
            label3.Text = "1 / 2";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (pnlSort1.Visible == false)
            {
                pnlSort1.Visible = true;
            }
            else
            {
                pnlSort1.Visible = false;
            }

        }

        // Sort function for category table
        private void sortStock(string str)
        {
            listView1.Items.Clear();
            connRep.Open();
            SqlCommand cmdRep = new SqlCommand($"SELECT category_id, name, number_of_items FROM category ORDER BY {str}", connRep);
            SqlDataReader drRep = cmdRep.ExecuteReader();

            while (drRep.Read())
            {
                ListViewItem addRep = new ListViewItem();

                addRep.Text = drRep["category_id"].ToString();
                addRep.SubItems.Add(drRep["name"].ToString());
                addRep.SubItems.Add(drRep["number_of_items"].ToString());


                listView1.Items.Add(addRep);

            }
            connRep.Close();
        }

        // Sort function products table
        private void sortPrice(string str)
        {
            listView2.Items.Clear();
            connRep.Open();
            SqlCommand cmdRep = new SqlCommand($"SELECT * FROM product ORDER BY {str}", connRep);
            SqlDataReader drRep = cmdRep.ExecuteReader();

            while (drRep.Read())
            {
                ListViewItem addRep = new ListViewItem();

                addRep.Text = drRep["product_id"].ToString();
                addRep.SubItems.Add(drRep["name"].ToString());
                addRep.SubItems.Add(drRep["unit_price"].ToString() + " $");


                listView2.Items.Add(addRep);

            }
            connRep.Close();
        }
        private void linkID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlPriceList.Visible == false)
            {
                sortStock("category_id");
            }
            else
            {
                sortPrice("product_id");
            }

        }

        private void linkName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlPriceList.Visible == false)
            {
                sortStock("name");
            }
            else
            {
                sortPrice("name");
            }
        }

        private void linkNumOfItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlPriceList.Visible == false)
            {
                sortStock("number_of_items");
            }
            else
            {
                sortPrice("unit_price");
            }
        }
    }
}
