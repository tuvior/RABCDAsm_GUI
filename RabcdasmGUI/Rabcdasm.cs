using MetroFramework.Forms;
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
    public partial class RABCDasm : MetroForm
    {
        string filepath;
        string path;
        string filename;
        string tag = "0";
        public RABCDasm()
        {
            InitializeComponent();
            filepath = "";
            filename = "";
            path = "";
            this.StyleManager = msmMain;
        }

        private void getABC()
        {
            string search = filename.Replace(".swf", "") + "-*.abc";
            string[] tags = Directory.GetFiles(path, search);

            object [] tagList = new object[tags.Length];

            for (int i = 0; i < tags.Length; i++)
            {
                tagList[i] = i;
            }

            tagSelector.Items.Clear();
            tagSelector.Items.AddRange(tagList);
            tagSelector.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.Title = "Pick SWF file";
            openFileDialog.Filter = "SWF files | *.swf";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            tagSelector.SelectedIndex = 0;
        }

        private void browseClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog.FileName;
                textBox1.Text = file;
                filepath = file;
                filename = openFileDialog.SafeFileName;
                path = filepath.Replace(filename, "");
                InfoLabel.Text = "Selected: " + filename;
                getABC();
            }
        }

        private void rabcdasmButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                string abcpath = path + filename.Replace(".swf", "-" + tag + ".abc");
                if (File.Exists(abcpath))
                {
                    InfoLabel.Text = "Dissassembling " + filename.Replace(".swf", "-" + tag + ".abc") + "...";
                    ToolLauncher.Rabcdasm(abcpath);
                    InfoLabel.Text = "Dissassembled " + filename.Replace(".swf", "-" + tag + ".abc") + " in /" + filename.Replace(".swf", "-" + tag) + "/";
                } 
                else
                {
                    InfoLabel.Text = "The ABC block " + filename.Replace(".swf", "-" + tag + ".abc") + " was not found";
                }

            }
            else 
            {
                InfoLabel.Text = "Select an SWF file first!";
            }
        }

        private void abcexportButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                InfoLabel.Text = "Exporting ABC tags...";
                ToolLauncher.AbcExport(filepath);
                InfoLabel.Text = "Exported ABC tags";
                getABC();
            }
            else
            {
                InfoLabel.Text = "Select an SWF file first!";
            }
        }

        private void rabcasmButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                string buildpath = path + filename.Replace(".swf", "-" + tag) + "/" + filename.Replace(".swf", "-" + tag) + ".main.asasm";
                if (File.Exists(buildpath))
                {
                    InfoLabel.Text = "Reassassembling " + filename.Replace(".swf", "-" + tag + ".abc") + "...";
                    ToolLauncher.Rabcasm(buildpath);
                    InfoLabel.Text = "Reassembled " + filename.Replace(".swf", "-" + tag + ".abc") + " in /" + filename.Replace(".swf", "-" + tag) + "/" + filename.Replace(".swf", "-" + tag) + ".main.abc";;
                }
                else
                {
                    InfoLabel.Text = "The build file /" + filename.Replace(".swf", "-" + tag) + "/" + filename.Replace(".swf", "-" + tag) + ".main.asasm" +" was not found";
                }
            }
            else
            {
                InfoLabel.Text = "Select an SWF file first!";
            }
        }

        private void AbcReplaceButton(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                string buildpath = path + filename.Replace(".swf", "-" + tag) + "/" + filename.Replace(".swf", "-" + tag) + ".main.abc";
                if (File.Exists(buildpath))
                {
                    InfoLabel.Text = "Reinserting ABC block...";
                    ToolLauncher.AbcReplace(filepath, tag, buildpath);
                    InfoLabel.Text = "ABC block inserted";
                }
                else
                {
                    InfoLabel.Text = "The ABC block /" + filename.Replace(".swf", "-" + tag) + "/" + filename.Replace(".swf", "-" + tag) + ".main.abc" + " was not found";
                }
            }
            else
            {
                InfoLabel.Text = "Select an SWF file first!";
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tag = tagSelector.SelectedItem + "";
        }
    }
}
