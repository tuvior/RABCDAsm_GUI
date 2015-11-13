using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabcdasmGUI
{
    public partial class Rabcdasm : Form
    {
        string filepath;
        string path;
        string filename;
        string tag = "0";
        public Rabcdasm()
        {
            InitializeComponent();
            filepath = "";
            filename = "";
            path = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.Title = "Pick SWF file";
            openFileDialog.Filter = "SWF files | *.swf";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            domainUpDown1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog.FileName;
                textBox1.Text = file;
                filepath = file;
                filename = openFileDialog.SafeFileName;
                path = filepath.Replace(filename, "");
                label1.Text = filename;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void rabcdasmButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                string abcpath = path + filename.Replace(".swf", "-" + tag + ".abc");
                if (File.Exists(abcpath))
                { 
                    ToolLauncher.Rabcdasm(abcpath);
                }
                
            }
        }

        private void abcexportButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                ToolLauncher.AbcExport(filepath);
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            tag = (string)domainUpDown1.SelectedItem;
        }

        private void rabcasmButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                string buildpath = path + filename.Replace(".swf", "-" + tag) + "/" + filename.Replace(".swf", "-" + tag) + ".main.asasm";
                if (File.Exists(buildpath))
                {
                    ToolLauncher.Rabcasm(buildpath);
                }
            }
        }

        private void AbcReplaceButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                string buildpath = path + filename.Replace(".swf", "-" + tag) + "/" + filename.Replace(".swf", "-" + tag) + ".main.abc";
                if (File.Exists(buildpath))
                {
                    ToolLauncher.AbcReplace(filepath, tag, buildpath);
                }
            }
        }
    }
}
