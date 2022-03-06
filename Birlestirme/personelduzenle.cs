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
    public partial class personelduzenle : Form
    { 
    perislem perislem = (perislem)Application.OpenForms["perislem"];
        //
        public string bilgi1, bilgi2, bilgi3, bilgi4, bilgi5, bilgi6;
        public personelduzenle()
        {
            InitializeComponent();
        }

        private void personelduzenle_Load(object sender, EventArgs e)
        {
            perkod.Text= perislem.bilgi1.ToString();
            isim.Text = perislem.bilgi2;
            cinsiyet.Text = perislem.bilgi3;
        }
        private void pervercek()
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (perkod.Text != "" && cinsiyet.Text != "" && isim.Text != "")
            {
                perislem.bilgi1 = Convert.ToInt32(perkod.Text);
                perislem.bilgi2 = isim.Text;
                perislem.bilgi3 = cinsiyet.Text;
                perislem.perdegonay = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Yerleri Doldur");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
