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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory_management_app
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"CONNECTION_STRING");

        // Check if table exists
        private bool tableExist(SqlConnection connection, string tableName)
        {
            using (SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'", connection))
            {
                // If num of rows != 0
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void addDeleteCell()
        {
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(6, delete);
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.FlatStyle = FlatStyle.Flat;
            delete.DefaultCellStyle.BackColor = Color.Red;
        }

        private void addEditCell()
        {
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(7, edit);
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.FlatStyle = FlatStyle.Flat;
            edit.DefaultCellStyle.BackColor = Color.Green;
        }

        private void showItems()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            connection.Open();
            if (!tableExist(connection, "product"))
            {
                SqlCommand createTable = new SqlCommand("CREATE TABLE product (product_id INT IDENTITY(1,1) PRIMARY KEY, name NVARCHAR(50), producer NVARCHAR(50), unit_price DECIMAL(10,2), category NVARCHAR(50), supplier NVARCHAR(50), photo NVARCHAR(500), description NVARCHAR(100))", connection);
                createTable.ExecuteNonQuery();
            }
            connection.Close();
            pnlFilter.Visible = false;
            photourl.Visible = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(867, 417);
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;

            //Fill category combobox
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM category", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(reader);
            cmbCategory.ValueMember = "name";
            cmbCategory.DataSource = dt;
            connection.Close();

            //Fill supplier combobox
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT name FROM supplier", connection);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("name", typeof(string));
            dt2.Load(reader2);
            cmbSupplier.ValueMember = "name";
            cmbSupplier.DataSource = dt2;
            connection.Close();

            //Show in data grid view
            showItems();

            //Delete button
            addDeleteCell();

            //Edit button
            addEditCell();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        //Cancel Button
        private void button2_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            txtName.Text = string.Empty;
            txtProducer.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            cmbCategory.Text = string.Empty;
            cmbSupplier.Text = string.Empty;
        }

        // Add item
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtProducer.Text != string.Empty && txtUnitPrice.Text != string.Empty && cmbCategory.Text != string.Empty && cmbSupplier.Text != string.Empty)
            {
                connection.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO product (name,producer,unit_price,category,supplier,photo,description) VALUES ('" + txtName.Text + "' ,'" + txtProducer.Text + "','" + txtUnitPrice.Text + "', '" + cmbCategory.Text + "', '" + cmbSupplier.Text + "','" + photourl.Text + "','" + txtDescription.Text + "')", connection);
                ekle.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Item is added succesfully");

                showItems();
            }
            else
            {
                MessageBox.Show("Please check information you entered");
                showItems();
            }
        }

        // Upload picture button
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp;)|*.jpg; *.jpeg; *.png; *.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photourl.Text = ofd.FileName;
                pictureBox2.Image = new Bitmap(ofd.FileName);
                pictureBox2.Tag = ofd.FileName;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            //Fill supplier combobox
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT name FROM supplier", connection);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();

            dt2.Columns.Add("name", typeof(string));
            dt2.Rows.Add(string.Empty);
            dt2.Load(reader2);
            cmbSuppFilter.ValueMember = "name";
            cmbSuppFilter.DataSource = dt2;
            connection.Close();

            //Fill category combobox
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM category", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("name", typeof(string));
            dt.Rows.Add(string.Empty);
            dt.Load(reader);
            cmbCategoryFilter.ValueMember = "name";
            cmbCategoryFilter.DataSource = dt;
            connection.Close();

            //Fill Price Range Box
            cmbPriceFilter.Items.Add(string.Empty);
            cmbPriceFilter.Items.Add("0-5");
            cmbPriceFilter.Items.Add("5-10");
            cmbPriceFilter.Items.Add("10-20");
            cmbPriceFilter.Items.Add("20-50");
            cmbPriceFilter.Items.Add("More than 50");


            if (pnlFilter.Visible == false)
            {
                pnlFilter.Visible = true;
            }
            else if (pnlFilter.Visible == true)
            {
                pnlFilter.Visible = false;
            }
        }

        static string photoPath = string.Empty;
        // Adjusting delete and edit buttons
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");
                SqlCommand delete = new SqlCommand("DELETE FROM product WHERE product_id=@id", conn);
                delete.Parameters.AddWithValue("id", row.Cells["id"].Value);
                conn.Open();
                delete.ExecuteNonQuery();
                conn.Close();
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            //Edit
            else if (e.ColumnIndex == 7 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                //Fill textboxes
                pnlEdit.Visible = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNameEdit.Text = row.Cells[1].Value.ToString();
                txtProdcuerEdit.Text = row.Cells[2].Value.ToString();
                txtUnitPriceEdit.Text = row.Cells[3].Value.ToString();
                cmbCategoryEdit.Text = row.Cells[4].Value.ToString();
                cmbSupplierEdit.Text = row.Cells[5].Value.ToString();


                //Fetch Picture
                int productId = Convert.ToInt32(row.Cells[0].Value);
                SqlCommand fetchPic = new SqlCommand($"SELECT photo, description FROM product WHERE product_id={productId}", connection);
                connection.Open();
                SqlDataReader reader = fetchPic.ExecuteReader();
                if (reader.Read())
                {

                    if (reader["photo"] != DBNull.Value)
                    {
                        photoPath = reader["photo"].ToString();
                        if (photoPath != string.Empty)
                        {
                            if (System.IO.File.Exists(photoPath))
                            {
                                picImageEdit.Image = Image.FromFile(photoPath);
                            }
                            else
                            {
                                picImageEdit.Image = null;
                            }

                        }
                        else
                        {
                            picImageEdit.Image = null;
                        }

                    }
                }
                txtDescriptionEdit.Text = reader["description"].ToString();

                reader.Close();
                connection.Close();
            }


        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            showItems();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            //Edit button
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int customerId = Convert.ToInt32(row.Cells["id"].Value);

            if (photourl.Text == "label8")
            {
                photoPath = photoPath.ToString();
            }
            else
            {
                photoPath = photourl.Text;
            }

            SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");

            SqlCommand update = new SqlCommand("UPDATE product SET name='" + txtNameEdit.Text + "', producer='" + txtProdcuerEdit.Text + "', unit_price='" + txtUnitPriceEdit.Text + "', category='" + cmbCategoryEdit.Text + "', supplier='" + cmbSupplierEdit.Text + "', photo='" + photoPath + "', description='" + txtDescriptionEdit.Text + "' WHERE product_id = " + customerId + "", conn);
            if (txtNameEdit.Text != string.Empty && txtProdcuerEdit.Text != string.Empty && txtUnitPriceEdit.Text != string.Empty && cmbCategoryEdit.Text != string.Empty && cmbSupplierEdit.Text != string.Empty && txtDescriptionEdit.Text != string.Empty)
            {
                conn.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Item is updated succesfully");
                pnlEdit.Visible = false;
            }
            else
            {
                MessageBox.Show("Please check information you entered");
            }

            showItems();
        }

        // Search
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string searchWord = txtSearch.Text;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE product_id LIKE '%" + txtSearch.Text + "%' OR name LIKE '%" + txtSearch.Text + "%' OR producer LIKE '%" + txtSearch.Text + "%' OR unit_price LIKE '%" + txtSearch.Text + "%' OR category LIKE '%" + txtSearch.Text + "%' OR supplier LIKE '%" + txtSearch.Text + "%'", connection);
            DataSet dsSearched = new DataSet();
            adapter.Fill(dsSearched);
            dataGridView1.DataSource = dsSearched.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

            //Delete button
            addDeleteCell();

            //Edit button
            addEditCell();


        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoryFilter.SelectedIndex > 0)
            {
                DataRowView selectedRow = (DataRowView)cmbCategoryFilter.SelectedItem;
                string selectedCategoryName = selectedRow["name"].ToString();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                SqlDataAdapter filterAdapter = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE category LIKE '%" + selectedCategoryName + "%'", connection);
                DataSet dsFiltered = new DataSet();
                filterAdapter.Fill(dsFiltered);
                dataGridView1.DataSource = dsFiltered.Tables[0];
                dataGridView1.AllowUserToAddRows = false;

                //Delete button
                addDeleteCell();

                //Edit button
                addEditCell();


            }
            else
            {

                showItems();

                //Delete button
                addDeleteCell();

                //Edit button
                addEditCell();
            }

        }

        private void cmbSuppFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSuppFilter.SelectedIndex > 0)
            {
                DataRowView selectedRow = (DataRowView)cmbSuppFilter.SelectedItem;
                string selectedSupplierName = selectedRow["name"].ToString();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                SqlDataAdapter filterAdapter = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE supplier LIKE '%" + selectedSupplierName + "%'", connection);
                DataSet dsFiltered = new DataSet();
                filterAdapter.Fill(dsFiltered);
                dataGridView1.DataSource = dsFiltered.Tables[0];
                dataGridView1.AllowUserToAddRows = false;

                //Delete button
                addDeleteCell();

                //Edit button
                addEditCell();
            }
            else
            {

                showItems();

                //Delete button
                addDeleteCell();

                //Edit button
                addEditCell();
            }
        }

        private void cmbPriceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPriceFilter.SelectedIndex > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                switch (cmbPriceFilter.SelectedIndex)
                {
                    //0-5
                    case 1:
                        SqlDataAdapter priceFilterAdapter1 = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE unit_price >= 0 AND unit_price <= 5", connection);
                        DataSet dsPriceFiltered1 = new DataSet();
                        priceFilterAdapter1.Fill(dsPriceFiltered1);
                        dataGridView1.DataSource = dsPriceFiltered1.Tables[0];
                        dataGridView1.AllowUserToAddRows = false;
                        addDeleteCell();
                        addEditCell();
                        break;
                    //5-10
                    case 2:
                        SqlDataAdapter priceFilterAdapter2 = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE unit_price >= 5 AND unit_price <= 10", connection);
                        DataSet dsPriceFiltered2 = new DataSet();
                        priceFilterAdapter2.Fill(dsPriceFiltered2);
                        dataGridView1.DataSource = dsPriceFiltered2.Tables[0];
                        dataGridView1.AllowUserToAddRows = false;
                        addDeleteCell();
                        addEditCell();
                        break;
                    //10-20
                    case 3:
                        SqlDataAdapter priceFilterAdapter3 = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE unit_price >= 10 AND unit_price <= 20", connection);
                        DataSet dsPriceFiltered3 = new DataSet();
                        priceFilterAdapter3.Fill(dsPriceFiltered3);
                        dataGridView1.DataSource = dsPriceFiltered3.Tables[0];
                        dataGridView1.AllowUserToAddRows = false;
                        addDeleteCell();
                        addEditCell();
                        break;
                    //20-50
                    case 4:
                        SqlDataAdapter priceFilterAdapter4 = new SqlDataAdapter("SELECT product_id AS [ID], name AS [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE unit_price >= 20 AND unit_price <= 50", connection);
                        DataSet dsPriceFiltered4 = new DataSet();
                        priceFilterAdapter4.Fill(dsPriceFiltered4);
                        dataGridView1.DataSource = dsPriceFiltered4.Tables[0];
                        dataGridView1.AllowUserToAddRows = false;
                        addDeleteCell();
                        addEditCell();
                        break;
                    //More than 50
                    case 5:
                        SqlDataAdapter priceFilterAdapter5 = new SqlDataAdapter("SELECT product_id as [ID], name as [Product Name], producer AS [Producer Name], unit_price AS [Unit Price], category AS [Category Name], supplier AS [Supplier Name] FROM product WHERE unit_price >= 50", connection);
                        DataSet dsPriceFiltered5 = new DataSet();
                        priceFilterAdapter5.Fill(dsPriceFiltered5);
                        dataGridView1.DataSource = dsPriceFiltered5.Tables[0];
                        dataGridView1.AllowUserToAddRows = false;
                        addDeleteCell();
                        addEditCell();
                        break;
                    default:
                        break;
                }
            }
            else
            {

                showItems();

                //Delete button
                addDeleteCell();

                //Edit button
                addEditCell();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Assuming you have a column named "photo" in your DataTable
                string columnName = "photo";

                // Fetch the file path from the database
                SqlDataAdapter photoAdapter = new SqlDataAdapter("SELECT photo FROM product", connection);
                DataSet dsPhoto = new DataSet();
                photoAdapter.Fill(dsPhoto, "Product");

                // Check if the DataTable contains the specified column
                if (dsPhoto.Tables["Product"].Columns.Contains(columnName))
                {
                    // Get the row corresponding to the double-clicked cell
                    DataRow row = dsPhoto.Tables["Product"].Rows[e.RowIndex];

                    // Get the file path from the "photo" column
                    string filePath = row[columnName].ToString();

                    // Load and display the image from the file path
                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    {
                        pictureBox7.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        MessageBox.Show("File not found or path is empty.");
                    }
                }

                // Assuming you have a column named "photo" in your DataTable
                string columnName1 = "description";

                // Fetch the file path from the database
                SqlDataAdapter descAdapter = new SqlDataAdapter("SELECT description FROM product", connection);
                DataSet dsDesc = new DataSet();
                descAdapter.Fill(dsDesc, "Product");

                // Check if the DataTable contains the specified column
                if (dsDesc.Tables["Product"].Columns.Contains(columnName1))
                {
                    // Get the row corresponding to the double-clicked cell
                    DataRow row = dsDesc.Tables["Product"].Rows[e.RowIndex];

                    // Get the file path from the "photo" column
                    txtDescriptionBox.Text = row[columnName1].ToString();



                }
            }
        }

        private void cmbSuppFilter_DropDown(object sender, EventArgs e)
        {
            cmbPriceFilter.SelectedIndex = -1;
            cmbCategoryFilter.SelectedIndex = -1;
        }

        private void cmbCategoryFilter_DropDown(object sender, EventArgs e)
        {
            cmbPriceFilter.SelectedIndex = -1;
            cmbSuppFilter.SelectedIndex = -1;
        }

        private void cmbPriceFilter_DropDown(object sender, EventArgs e)
        {
            cmbCategoryFilter.SelectedIndex = -1;
            cmbSuppFilter.SelectedIndex = -1;
        }

        private void btnUploadEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp;)|*.jpg; *.jpeg; *.png; *.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photourl.Text = ofd.FileName;
                picImageEdit.Image = new Bitmap(ofd.FileName);
                picImageEdit.Tag = ofd.FileName;
            }
        }
    }
}

