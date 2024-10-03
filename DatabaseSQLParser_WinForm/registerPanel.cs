using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSQLParser_WinForm
{
    public partial class registerPanel : Form
    {

        public registerPanel()
        {
            InitializeComponent();
        }

        static string connectionString = "datasource=127.0.0.1; port=3306; username=root; password= ; database=sql_prog; sslmode=none";
        MySqlConnection databaseConnection;

        private static void registerPanel_Load(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username = textBox_r_username.Text;
            string password = textBox_r_password.Text;
            string email = textBox_email.Text;
            string name = textBox_name.Text;
            string query = " INSERT INTO users (username, password, email, name) VALUES ('" + username + "', '" + password + "', '" + email + "', '" + name + "');";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    databaseConnection.Close();
                }
                else
                {
                    Console.WriteLine("NO rows found");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
