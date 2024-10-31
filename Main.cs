using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_app
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            btnProduct.FlatAppearance.BorderSize = 0;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.BorderSize = 0;
            pnlDefault.Visible = true;

        }


        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            pnlHome.BackColor = Color.WhiteSmoke;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            pnlHome.BackColor = Color.FromArgb(9, 20, 64);
        }

        private void btnCategory_MouseEnter(object sender, EventArgs e)
        {
            pnlCategory.BackColor = Color.WhiteSmoke;
        }

        private void btnCategory_MouseLeave(object sender, EventArgs e)
        {
            pnlCategory.BackColor = Color.FromArgb(9, 20, 64);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlDefault.Visible = false;
            Product product = new Product();
            product.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void btnSuppliers_MouseEnter(object sender, EventArgs e)
        {
            pnlSuppliers.BackColor = Color.WhiteSmoke;
        }

        private void btnSuppliers_MouseLeave(object sender, EventArgs e)
        {
            pnlSuppliers.BackColor = Color.FromArgb(9, 20, 64);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        {
            pnlCustomers.BackColor = Color.WhiteSmoke;
        }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            pnlCustomers.BackColor = Color.FromArgb(9, 20, 64);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
            pnlReport.BackColor = Color.WhiteSmoke;
        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            pnlReport.BackColor = Color.FromArgb(9, 20, 64);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
