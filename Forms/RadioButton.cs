using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsRadioButton
{
    public partial class Form1 : Form
    {
        int nSel = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (nSel != 1)
            {
                nSel = 1;
                MessageBox.Show("1");
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (nSel != 2)
            {
                nSel = 2;
                MessageBox.Show("2");
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (nSel != 3)
            {
                nSel = 3;
                MessageBox.Show("3");
            }
        }
    }
}
