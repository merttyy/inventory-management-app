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
using System.Xml.Linq;

namespace inventory_management_app
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        //Connection string
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

        //Displaying table
        private void showItems()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT supplier_id AS [ID], name AS [Supplier Name], phone AS [Phone Number], email AS [Mail Address], address AS [Address]  FROM supplier", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            connection.Open();
            if (!tableExist(connection, "supplier"))
            {
                SqlCommand createTable = new SqlCommand("CREATE TABLE supplier (supplier_id INT IDENTITY(1,1) PRIMARY KEY, name NVARCHAR(50), phone NVARCHAR(50) UNIQUE, email NVARCHAR(50) UNIQUE, address NVARCHAR(50))", connection);
                createTable.ExecuteNonQuery();
            }
            connection.Close();
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(867, 417);

            //Show in data grid view
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT supplier_id AS [ID], name AS [Supplier Name], phone AS [Phone Number], email AS [Mail Address], address AS [Address] FROM supplier", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

            //Delete button
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(5, delete);
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.FlatStyle = FlatStyle.Flat;
            delete.DefaultCellStyle.BackColor = Color.Red;

            //Edit button
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(6, edit);
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.FlatStyle = FlatStyle.Flat;
            edit.DefaultCellStyle.BackColor = Color.Green;
        }


        //Adding new items to table
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && mtxtPhone.Text != string.Empty && txtMail.Text != string.Empty && txtAddress.Text != string.Empty)
            {
                try
                {
                    connection.Open();
                    SqlCommand ekle = new SqlCommand("INSERT INTO supplier (name,phone,email,address) VALUES ('" + txtName.Text + "' ,'" + mtxtPhone.Text + "','" + txtMail.Text + "', '" + txtAddress.Text + "')", connection);
                    ekle.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Succesfully added");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Please enter another phone number or email");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }
                showItems();
            }
            else
            {
                MessageBox.Show("Please check information you entered");
                showItems();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            txtName.Text = string.Empty;
            mtxtPhone.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtAddress.Text = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        // Adjusting edit and delete buttons
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");
                SqlCommand delete = new SqlCommand("DELETE FROM supplier WHERE supplier_id=@id", conn);
                delete.Parameters.AddWithValue("id", row.Cells["id"].Value);
                conn.Open();
                delete.ExecuteNonQuery();
                conn.Close();
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                showItems();
            }
            else if (e.ColumnIndex == 6)
            {
                //Fill textboxes
                pnlEdit.Visible = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNameEdit.Text = row.Cells[1].Value.ToString();
                mtxtPhoneEdit.Text = row.Cells[2].Value.ToString();
                txtEmailEdit.Text = row.Cells[3].Value.ToString();
                txtAddressEdit.Text = row.Cells[4].Value.ToString();

            }
        }

        //Update existing item
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            //Edit button
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int supplierId = Convert.ToInt32(row.Cells["id"].Value);

            try
            {
                SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");
                SqlCommand update = new SqlCommand("UPDATE supplier SET name='" + txtNameEdit.Text + "', phone='" + mtxtPhoneEdit.Text + "', email='" + txtEmailEdit.Text + "', address='" + txtAddressEdit.Text + "' WHERE supplier_id = " + supplierId + "", conn);

                if (txtNameEdit.Text != string.Empty && mtxtPhoneEdit.Text != string.Empty && txtEmailEdit.Text != string.Empty && txtAddressEdit.Text != string.Empty)
                {
                    conn.Open();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully");
                    pnlEdit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please enter valid data");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Please enter another phone number or email");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT supplier_id AS [ID], name AS [Supplier Name], phone AS [Phone Number], email AS [Mail Address], address AS [Address] FROM supplier", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT supplier_id AS [ID], name AS [Supplier Name], phone AS [Phone Number], email AS [Mail Address], address AS [Address] FROM supplier", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        //Search items
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string searchWord = txtSearch.Text;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT supplier_id AS [ID], name AS [Supplier Name], phone AS [Phone Number], email AS [Mail Address], address AS [Address] FROM supplier WHERE supplier_id LIKE '%" + txtSearch.Text + "%' OR name LIKE '%" + txtSearch.Text + "%' OR phone LIKE '%" + txtSearch.Text + "%' OR email LIKE '%" + txtSearch.Text + "%' OR address LIKE '%" + txtSearch.Text + "%'", connection);
            DataSet dsSearched = new DataSet();
            adapter.Fill(dsSearched);
            dataGridView1.DataSource = dsSearched.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

            //Delete button
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(5, delete);
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.FlatStyle = FlatStyle.Flat;
            delete.DefaultCellStyle.BackColor = Color.Red;

            //Edit button
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(6, edit);
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.FlatStyle = FlatStyle.Flat;
            edit.DefaultCellStyle.BackColor = Color.Green;


        }
    }
}
