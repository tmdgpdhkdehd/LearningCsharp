using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsListbox
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
            listBox1.Items.Add("C");
            listBox1.Items.Add("CPP");
            listBox1.Items.Add("CSharp");
            listBox1.Items.Add("Unity");

            // 정회원이 기본 선택
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(nSel!=listBox1.SelectedIndex)
            {
                nSel = listBox1.SelectedIndex;

                string str="";
                switch (nSel)
                {
                    case 0: str = "C"; break;
                    case 1: str = "CPP"; break;
                    case 2: str = "CSharp"; break;
                    case 3: str = "Unity"; break;
                }
                MessageBox.Show(str);
            }
        }
    }
}
