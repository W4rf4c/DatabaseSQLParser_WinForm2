using System.Web;

namespace DatabaseSQLParser_WinForm
{
    
    public partial class Form1 : Form
    {
        public static string drive;
        public Form1()
        {
            InitializeComponent();
        }
        static string insertQuery = "INSERT INTO ";

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

        private void button1_Click(object sender, EventArgs e)
        {
            SQL();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string SavedTextFile = comboBox2.Text+"Test.txt";

            SQL();

            try
            {
                StreamWriter sw = new StreamWriter(SavedTextFile);
                sw.WriteLine(comboBox1.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveSelection d2 = new DriveSelection();
            d2.ShowDialog();
        }
    }
}