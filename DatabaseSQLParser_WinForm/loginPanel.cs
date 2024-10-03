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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseSQLParser_WinForm
{
    public partial class loginPanel : Form
    {
        public loginPanel()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {   
            registerPanel register = new registerPanel();
            register.ShowDialog();
        }

        private void loginPanel_Load(object sender, EventArgs e)
        {

        }

        static string connectionString = "datasource=127.0.0.1; port=3306; username=root; password= ; database=sql_prog; sslmode=none";
        
        private void button_login_Click(object sender, EventArgs e)
        {
            
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string username = textBox_l_username.Text;
            string password = textBox_l_password.Text;
            string query = "SELECT username, password FROM users WHERE username = '" + username + "' AND password = '" + password + "';";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    databaseConnection.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
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
