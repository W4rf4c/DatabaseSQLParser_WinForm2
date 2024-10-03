using System.Web;
using MySql.Data.MySqlClient;

namespace DatabaseSQLParser_WinForm
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string insertQuery = "INSERT INTO ";
        static string connectionString = "datasource=127.0.0.1; port=3306; username=root; password= ; database=sql_prog; sslmode=none";
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);


        public void SQL()
        {
            string textFile = comboBox1.Text;
            DirectoryInfo dinfo = new DirectoryInfo(textFile);
            FileInfo[] Files = dinfo.GetFiles("*.txt");

            foreach (var item in Files)
            {
                richTextBox1.AppendText("\r\n");
                richTextBox1.ScrollToCaret();
                insertQuery = "INSERT INTO ";
                if (!item.ToString().Contains("SQL.txt"))
                {
                    //richTextBox1.Text=richTextBox1.Text+item.ToString();

                    insertQuery += FindTableName(item.ToString()) + " (";
                    //Read Input File
                    string[] lines = File.ReadAllLines(item.ToString());
                    //Split Header
                    string[] splittedFirstRow = lines[0].Split('\t');
                    for (int i = 0; i < splittedFirstRow.Length; i++)
                    {
                        insertQuery += splittedFirstRow[i];
                        if (i == splittedFirstRow.Length - 1)
                        {
                            insertQuery += ") ";
                        }
                        else
                        {
                            insertQuery += ", ";
                        }
                    }

                    insertQuery += "VALUES ";

                    //Split Values
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] splittedRow = lines[i].Split('\t');
                        insertQuery += "(";

                        for (int j = 0; j < splittedRow.Length; j++)
                        {
                            CheckType(splittedRow[j]);

                            if (j < splittedRow.Length - 1)
                            {
                                insertQuery += ", ";
                            }
                        }
                        if (i == lines.Length - 1)
                        {
                            insertQuery += ");";
                        }
                        else
                            insertQuery += "), ";
                    }
                    richTextBox1.Text = richTextBox1.Text + insertQuery;
                    File.WriteAllText(SqlFile(item.ToString()), insertQuery);
                    richTextBox1.Text = richTextBox1.Text + "\r \n" + "Write was successful";
                    
                }
            }
        }

        //Check if varchar/int/double
        public static void CheckType(string item)
        {
            if (int.TryParse(item, out int numValue))
            {
                insertQuery += numValue.ToString();
            }
            else if (double.TryParse(item, out double dValue))
            {
                insertQuery += dValue.ToString();
            }
            else
            {
                insertQuery += "'" + item + "'";
            }
        }

        //Find table name

        public static string FindTableName(string fileLocation)
        {
            string s = @"\";

            string[] a = fileLocation.Split(s);
            s = ".";
            a = a[a.Length - 1].Split(s);
            return a[0];
        }

        public static string SqlFile(string fileLocation)
        {
            string s = @".";

            string[] a = fileLocation.Split(s);
            return a[a.Length - 2] + "SQL." + a[a.Length - 1];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT destination FROM destination_table INNER JOIN users " +
                "ON destination_table.username=users.username WHERE username='"+";";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0));
                    }
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

        private void query_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM destination_table;";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open(); 
                MySqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("Command executed");
                Drives.Rows.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1)};
                        DataGridViewRow gridRow = (DataGridViewRow)Drives.Rows[0].Clone();
                        gridRow.Cells[0].Value = row[0];
                        gridRow.Cells[1].Value = row[1];
                        Drives.Rows.Add(gridRow);
                    }
                }
                else
                {
                    Console.WriteLine("NO rows found");
                }
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void kiolvas_Click(object sender, EventArgs e)
        {
            string guery = "SELECT destination, id FROM destination_table WHERE id = 1";

            MySqlCommand command =new MySqlCommand(guery, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read()) 
                    { 
                        //Console.WriteLine(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string location = comboBox1.Text;
            string query = "DELETE FROM destination_table WHERE destination = '"+location+"';";

            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected>0)
                {
                    cw.Text = location + " Deleted successfully";
                }
                else
                {
                    cw.Text = "There is no destination like this";
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            SQL();

            string location = comboBox1.Text;
            cw.Text = location;
            string guery = "INSERT INTO destination_table (destination) VALUES ('" + location + "');";

            MySqlCommand command = new MySqlCommand(guery, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                }
                else
                {
                    Console.WriteLine("No rows found");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}