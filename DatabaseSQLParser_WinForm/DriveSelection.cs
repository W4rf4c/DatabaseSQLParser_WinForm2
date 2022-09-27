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
    public partial class DriveSelection : Form
    {
        public DriveSelection()
        {
            InitializeComponent();
        }

        private void DriveSelection_Load(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                comboBox1.Items.Add(drive.Name);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.drive = comboBox1.SelectedItem.ToString();
            this.Close();
        }
    }
}
