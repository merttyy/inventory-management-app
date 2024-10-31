using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace inventory_management_app
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            if (!tableExist(connection, "users"))
            {
                SqlCommand createTable = new SqlCommand("CREATE TABLE users (user_id INT IDENTITY(1,1) PRIMARY KEY, username NVARCHAR(50) UNIQUE, password NVARCHAR(50))", connection);
                createTable.ExecuteNonQuery();
                SqlCommand ekle = new SqlCommand("INSERT INTO users (username,password) VALUES ('" + "admin" + "' ,'" + "admin" + "')", connection);
                ekle.ExecuteNonQuery();
            }
            connection.Close();
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            picUnlocked.Visible = false;
            pnlReset.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM users WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connection.Close();
            if (dt.Rows[0][0].ToString() == "1")
            {
                picLocked.Visible = false;
                picUnlocked.Visible = true;
                MessageBox.Show("Succesful");
                Main mainMenu = new Main();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlReset.Visible = true;
        }

        private void btnCancelPas_Click(object sender, EventArgs e)
        {
            pnlReset.Visible = false;
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == textBox3.Text && textBox2.Text != "admin")
            {
                SqlCommand update = new SqlCommand("UPDATE users SET password='" + textBox1.Text + "' WHERE username = '" + textBox2.Text + "'", connection);
                connection.Open();
                update.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Password is updated");
            }
            else
            {
                MessageBox.Show("Please try again");    
            }
            
        }
    }
}