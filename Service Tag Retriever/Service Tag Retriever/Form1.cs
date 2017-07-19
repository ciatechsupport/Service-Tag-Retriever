using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Service_Tag_Retriever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RetrieveData_Click(object sender, EventArgs e)
        {
            textBox1.Text = Hardware.GetBIOSserNo();
            textBox2.Text = Hardware.GetUser();

           /* if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, result);
            }
            */
        }

        private void openLocation_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string result = "Service Tag:  " + textBox1.Text + "    User:  " + textBox2.Text;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, result);
                textBox3.Text = "File Created!";
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Process.Start("notepad.exe", saveFileDialog1.FileName);
            }
        }
    }
}
