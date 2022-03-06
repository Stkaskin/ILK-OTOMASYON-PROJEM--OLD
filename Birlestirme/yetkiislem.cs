using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Birlestirme
{
    public partial class yetkiislem : Form
    {
        public yetkiislem()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(doldur01);
            th.Start();
        }
        private void doldur01()
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value += 1; Thread.Sleep(150);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(doldur02);
            th.Start();
        }
        private void doldur02()
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar2.Value += 1; Thread.Sleep(150);
            }
        }

        private void yetkiislem_Load(object sender, EventArgs e)
        {

        }
    }
}
