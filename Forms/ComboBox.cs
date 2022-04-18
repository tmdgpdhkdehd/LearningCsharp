using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsComboBox
{
    public partial class Form1 : Form
    {
        int nSel = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "C", "CPP", "CSharp", "WinAPI","Unity" };

            // 각 콤보박스에 데이타를 초기화
            comboBox1.Items.AddRange(data);
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nSel != comboBox1.SelectedIndex)
            {
                nSel = comboBox1.SelectedIndex;

                string str = comboBox1.SelectedItem as string;
                MessageBox.Show(str);
            }
        }
    }
}
