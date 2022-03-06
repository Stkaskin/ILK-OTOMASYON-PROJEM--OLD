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
    public partial class Satıssoru : Form
    {
        public Satıssoru()
        {
            InitializeComponent();
        }
        satisislem form3 = (satisislem)Application.OpenForms["satisislem"];
        public int fiyat, tutar, adet; public bool satisonay = false;
        private void button1_Click(object sender, EventArgs e)
        {
            satisonay = true;
             //fiyat=Convert.ToInt32(textBox4.Text);
            if (miktartext.Text != "" && miktartext.Text[0]!='0')
            {
                adet = Convert.ToInt32(miktartext.Text);
                this.Close(); tutar = adet * fiyat;
            }
            else { MessageBox.Show("Geçerli Miktar Girin"); miktartext.Focus(); }
               
          /*  
            int satir = form3.listeurun.Rows.Add();
            form3.listeurun.Rows[satir].Cells[0].Value = satir + 157;
               form3.listeurun.Rows[satir].Cells[1].Value = satir;
               form3.listeurun.Rows[satir].Cells[2].Value = "Elma";

               form3.listeurun.Rows[satir].Cells[6].Value = "Ali Cemal Terci";
               form3.listeurun.Rows[satir].Cells[3].Value = fiyat;
               form3.listeurun.Rows[satir].Cells[4].Value = adet;
               form3.listeurun.Rows[satir].Cells[5].Value = tutar;*/
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Satıssoru_Load(object sender, EventArgs e)
        {
            label9.Text = form3.urunismigönder;
            label10.Text = form3.stokkodugönder;
            label11.Text = form3.fiyatgönder;
            miktartext.Focus();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (miktartext.Text != "")
            {
                tutar = Convert.ToInt32(label11.Text) * Convert.ToInt32(miktartext.Text);
                label7.Text = tutar.ToString();
            }
            else 
            {
                label7.Text = "0";
            }
        }
    }
}
