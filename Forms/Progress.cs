using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsProgress
{
    public partial class Form1 : Form
    {
        Timer timer;
        int cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            // 한 스텝 이동
            progressBar1.PerformStep();

            // 타이머 중지 조건
            if (cnt++ == 10)
            {
                cnt = 0;
                progressBar1.Value = 0;
            }
        }
    }
}
