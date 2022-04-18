using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsTooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "이것은 버튼 입니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 눌렀습니다.");
        }
    }
}
