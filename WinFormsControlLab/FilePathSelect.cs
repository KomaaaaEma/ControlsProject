using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLab
{
    public partial class FilePathSelect : UserControl
    {
        public FilePathSelect()
        {
            InitializeComponent();
        }
        public string FileName
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = FileName;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileName = openFile.FileName;
            }
        }
    }
}
