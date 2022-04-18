using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            string str = string.Format("{0}년 {1}월 {2}일", dt.Year, dt.Month, dt.Day);
            MessageBox.Show(str, "choose date");
        }
    }
}
