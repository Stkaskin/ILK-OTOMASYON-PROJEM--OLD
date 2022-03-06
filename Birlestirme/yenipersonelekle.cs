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
    public partial class yenipersonelekle : Form
    {
        perislem perislem = (perislem)Application.OpenForms["perislem"];

        public yenipersonelekle()
        {
            InitializeComponent();
        }
        private void yenipersonelekle_Load(object sender, EventArgs e)
        {
            perkodlabel.Text = perislem.bilgi1.ToString();
            cinsiyet.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isim.Text != "" && cinsiyet.Text != "")
            {
                perislem.bilgi2 = isim.Text;
                perislem.bilgi3 = cinsiyet.Text;
                perislem.ekleonay = true;
                this.Close();


            }
            else { MessageBox.Show("Boşlukları Doldur"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

      
    }
}
