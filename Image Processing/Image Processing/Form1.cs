using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(uxOpenFile.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();

                Bitmap image1 = (Bitmap)Image.FromFile(uxOpenFile.FileName, true);
                

            }
        }
    }
}
