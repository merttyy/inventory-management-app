using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using System.Data.SqlClient;

namespace inventory_management_app
{
    public partial class Category : Form
    {
        public Category()
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
        private void showItems()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT category_id AS [ID], name AS [Category Name], number_of_items AS [Number Of Items] FROM category", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
        }
        private void Category_Load(object sender, EventArgs e)
        {
            connection.Open();
            if (!tableExist(connection, "category"))
            {
                SqlCommand createTable = new SqlCommand("CREATE TABLE category (category_id INT IDENTITY(1,1) PRIMARY KEY, name NVARCHAR(50), number_of_items INT)", connection);
                createTable.ExecuteNonQuery();
                connection.Close();
                showItems();
            }

            connection.Close();
            pnlAdd.Visible = false;
            pnlEdit.Visible = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(867, 417);

            //Show in data grid view
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT category_id AS [ID], name AS [Category Name], number_of_items AS [Number Of Items] FROM category", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

            //Delete button
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(3, delete);
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.FlatStyle = FlatStyle.Flat;
            delete.DefaultCellStyle.BackColor = Color.Red;

            //Edit button
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(4, edit);
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

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            txtName.Text = string.Empty;
            txtNumOfItems.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtNumOfItems.Text != string.Empty)
            {
                showItems();
                try
                {
                    connection.Open();
                    SqlCommand ekle = new SqlCommand("INSERT INTO category (name,number_of_items) VALUES ('" + txtName.Text + "' ,'" + txtNumOfItems.Text + "')", connection);
                    ekle.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Succesfully added");
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
            }
            else
            {
                MessageBox.Show("Please enter valid data");
                showItems();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");
                SqlCommand delete = new SqlCommand("DELETE FROM category WHERE category_id=@id", conn);
                delete.Parameters.AddWithValue("id", row.Cells["id"].Value);
                conn.Open();
                delete.ExecuteNonQuery();
                conn.Close();
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            else if (e.ColumnIndex == 4)
            {
                //Fill textboxes
                pnlEdit.Visible = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNameEdit.Text = row.Cells[1].Value.ToString();
                txtNumEdit.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            //Edit button
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int categoryId = Convert.ToInt32(row.Cells["id"].Value);

            try
            {
                SqlConnection conn = new SqlConnection(@"CONNECTION_STRING");
                SqlCommand update = new SqlCommand("UPDATE category SET name='" + txtNameEdit.Text + "', number_of_items='" + txtNumEdit.Text + "' WHERE category_id = " + categoryId + "", conn);

                if (txtNameEdit.Text != string.Empty && txtNumEdit.Text != string.Empty)
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
            showItems();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            showItems();
        }

        // Search
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string searchWord = txtSearch.Text;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT category_id AS [ID], name AS [Category Name], number_of_items AS [Number Of Items] FROM category " +
                "WHERE category_id like '%" + txtSearch.Text + "%' or name like '%" + txtSearch.Text + "%' or number_of_items like '" + txtSearch.Text + "%'", connection);
            DataSet dsSearched = new DataSet();
            adapter.Fill(dsSearched);
            dataGridView1.DataSource = dsSearched.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

            //Delete button
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(3, delete);
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.FlatStyle = FlatStyle.Flat;
            delete.DefaultCellStyle.BackColor = Color.Red;

            //Edit button
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(4, edit);
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.FlatStyle = FlatStyle.Flat;
            edit.DefaultCellStyle.BackColor = Color.Green;


        }
    }
}
