using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birlestirme
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunislem urunislem = new urunislem();
            urunislem.Dock = DockStyle.Fill;
            urunislem.TopLevel = false;
            urunislem.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(urunislem);
            urunislem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perislem urunislem = new perislem();
            urunislem.Dock = DockStyle.Fill;
            urunislem.TopLevel = false;
            urunislem.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(urunislem);
            urunislem.Show();
            urunislem.BackColor = this.BackColor;
        }
    }
}
