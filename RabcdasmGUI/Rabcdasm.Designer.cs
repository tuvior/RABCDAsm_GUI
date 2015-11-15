using MetroFramework.Controls;
using MetroFramework.Forms;

namespace RabcdasmGUI
{
    partial class RABCDasm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RABCDasm));
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.button5 = new MetroFramework.Controls.MetroButton();
            this.button6 = new MetroFramework.Controls.MetroButton();
            this.InfoLabel = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tagSelector = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(266, 2);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Enabled = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(23, 63);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.browseClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "RABCDAsm";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.rabcdasmButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "ABC Export";
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.abcexportButton);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 24);
            this.button5.TabIndex = 5;
            this.button5.Text = "RABCAsm";
            this.button5.UseSelectable = true;
            this.button5.Click += new System.EventHandler(this.rabcasmButton);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(168, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 24);
            this.button6.TabIndex = 6;
            this.button6.Text = "ABC Replace";
            this.button6.UseSelectable = true;
            this.button6.Click += new System.EventHandler(this.AbcReplaceButton);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(23, 160);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(64, 19);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "ABC Tag";
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Purple;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tagSelector
            // 
            this.tagSelector.FormattingEnabled = true;
            this.tagSelector.ItemHeight = 23;
            this.tagSelector.Items.AddRange(new object[] {
            "-"});
            this.tagSelector.Location = new System.Drawing.Point(327, 119);
            this.tagSelector.Name = "tagSelector";
            this.tagSelector.Size = new System.Drawing.Size(59, 29);
            this.tagSelector.Sorted = true;
            this.tagSelector.TabIndex = 11;
            this.tagSelector.UseSelectable = true;
            this.tagSelector.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // RABCDasm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 199);
            this.Controls.Add(this.tagSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RABCDasm";
            this.Resizable = false;
            this.Text = "RABCDAsm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroButton button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroButton button2;
        private MetroButton button3;
        private MetroButton button5;
        private MetroButton button6;
        private MetroLabel InfoLabel;
        private MetroTextBox textBox1;
        private MetroLabel label2;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroComboBox tagSelector;

    }
}

