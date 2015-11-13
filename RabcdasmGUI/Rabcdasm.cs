using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabcdasmGUI
{
    public partial class Rabcdasm : Form
    {
        string filepath;
        string filename;
        public Rabcdasm()
        {
            InitializeComponent();
            filepath = "";
            filename = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Pick SWF file";
            openFileDialog1.Filter = "SWF files | *.swf";
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox1.Text = file;
                filepath = file;
                filename = openFileDialog1.SafeFileName;
                label1.Text = filename;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
