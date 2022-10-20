using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseSQLParser_WinForm
{
    public partial class loginPanel : Form
    {
        public loginPanel()
        {
            InitializeComponent();
        }

        static string insertQuery = "INSERT INTO ";
        static string connectionString = "datasource=127.0.0.1; port=3306; username=root; password= ; database=sql_prog; sslmode=none";
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        
        private void button_register_Click(object sender, EventArgs e)
        {
            registerPanel register = new registerPanel();
            register.Show();
        }

        private void loginPanel_Load(object sender, EventArgs e)
        {
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_l_username.Text;
            string query = "SELECT username, password FROM users WHERE username = '" + username + "';";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected==1)
                {
                    
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
    }
}
