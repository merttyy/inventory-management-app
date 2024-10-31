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

namespace inventory_management_app
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"CONNECTION_STRING");

        // Check if table exists
        private bool tableExist(SqlConnection connection, string tableName)
        {
            using (SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'",connection))
            {
                // If num of rows != 0
                int count=(int)cmd.ExecuteScalar();
                return count > 0;   
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            connection.Open();
            if (!tableExist(connection,"customer"))
            {
                SqlCommand createTable = new SqlCommand("CREATE TABLE customer (customer_id INT IDENTITY(1,1) PRIMARY KEY, name NVARCHAR(50), phone NVARCHAR(50), email NVARCHAR(50) UNIQUE, address NVARCHAR(50))", connection);
                createTable.ExecuteNonQuery();
                connection.Close();
            }
            connection.Close();
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(867, 417);

            //Show in data grid view
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT customer_id AS [ID], name AS [Customer Name], phone AS [Phone Number], email AS [Mail Address], address AS [Address] FROM customer", connection);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && mtxtPhone.Text != string.Empty && txtMail.Text != string.Empty && txtAddress.Text != string.Empty)
            {
                try
                {
                    connection.Open();
                    SqlCommand ekle = new SqlCommand("INSERT INTO customer (name,phone,email,address) VALUES ('" + txtName.Text + "' ,'" + mtxtPhone.Text + "','" + txtMail.Text + "', '" + txtAddress.Text + "')", connection);
                    ekle.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Succesfully added");
                }
                catch (SqlException ex)
                {
                    if(ex.Number== 2627 || ex.Number== 2601)
                    {
                        MessageBox.Show("Please enter another email");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                {
                    if(connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }

                SqlDataAdapter adapter = new SqlDataAdapter("Select customer_id as [ID], name as [Customer Name], phone as [Phone Number], email as [Mail Address], address as [Address]  from customer", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AllowUserToAddRows = false;

            }
            else
            {
                MessageBox.Show("Please enter valid data");

                SqlDataAdapter adapter = new SqlDataAdapter("Select customer_id as [ID], name as [Customer Name], phone as [Phone Number], email as [Mail Address], address as [Address]  from customer", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AllowUserToAddRows = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");
                SqlCommand delete = new SqlCommand("DELETE FROM customer WHERE customer_id=@id", conn);
                delete.Parameters.AddWithValue("id", row.Cells["id"].Value);
                conn.Open();
                delete.ExecuteNonQuery();
                conn.Close();
                dataGridView1.Rows.RemoveAt(e.RowIndex);
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

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            //Edit button
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int customerId = Convert.ToInt32(row.Cells["id"].Value);

            try
            {
                SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");
                SqlCommand update = new SqlCommand("UPDATE customer SET name='" + txtNameEdit.Text + "', phone='" + mtxtPhoneEdit.Text + "', email='" + txtEmailEdit.Text + "', address='" + txtAddressEdit.Text + "' WHERE customer_id = " + customerId + "", conn);

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
                    MessageBox.Show("Please enter another email");
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

            SqlDataAdapter adapter = new SqlDataAdapter("Select customer_id as [ID], name as [Customer Name], phone as [Phone Number], email as [Mail Address], address as [Address]  from customer", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

        }
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            SqlDataAdapter adapter = new SqlDataAdapter("Select customer_id as [ID], name as [Customer Name], phone as [Phone Number], email as [Mail Address], address as [Address]  from customer", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string searchWord = txtSearch.Text;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT customer_id AS [ID], name AS [Customer Name], phone AS [Phone Number], email AS [Mail Address], address AS [Address] FROM customer WHERE customer_id LIKE '%" + txtSearch.Text + "%' OR name LIKE '%" + txtSearch.Text + "%' OR phone LIKE '%" + txtSearch.Text + "%' OR email LIKE '%" + txtSearch.Text + "%' OR address LIKE '%" + txtSearch.Text + "%'", connection);
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
