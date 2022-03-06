using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Birlestirme
{
    public partial class urunekle : Form
    {
        Menü menü = (Menü)Application.OpenForms["Menü"];
        int abc = 0;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");
       
        bool sayiharf; int stokkodunubul, tutulacak;
        int stokcesit; bool menuackapa = false, cikisizin = false;
        public urunekle()
        {
            InitializeComponent();
        }
        private void kontrolbos()
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (urunad.Text == "" || urunad.Text == " ") { MessageBox.Show("Lütfen Ürün Adı Girin"); urunad.Focus(); }
            else if (turbilgi.Text == ""  && boyut.Text == "") { MessageBox.Show("Lütfen Tür / Ağırlık / Boyut En Az Birini Girin"); turbilgi.Focus(); }
            else if (fiyat.Text == "") { MessageBox.Show("Lütfen Fiyat Girin"); fiyat.Focus(); }
            else
            {
                kodsira();

                OleDbCommand komut = new OleDbCommand();

                MessageBox.Show("Stoğa Eklendi \n Stok Kodunuz:" + stokkodunubul);
                komut.Connection = baglanti;


                komut.CommandText = "insert into ÜRÜN (Kodu,Ürün,TÜR,BOYUT,FİYAT,AĞIRLIK,Bilgi) values (" + stokkodunubul + ",'" + urunad.Text.ToString() + "','" + turbilgi.Text.ToString() + "','" + boyut.Text.ToString() + "','" + fiyat.Text.ToString() + "','" + olcutu.Text.ToString() + "','" + markabilgi.Text.ToString() +"')";
                komut.ExecuteNonQuery();

            
                cikisizin = true;

            }


               
            
        }



        void kodsira()
        {
          
           
            



            for (int i = 1; ; i++)
            {

                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;
               
                kom.CommandText = "Select * From Ürün where Kodu like " + i + "";
                OleDbDataReader oku2 = kom.ExecuteReader();

                if (oku2.Read())
                {




                }
                else { stokkodunubul = i; break; }
            }


        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            if (cikisizin)
            {
                menü.panelsiras = -1;
                baglanti.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            menü.panelsiras = -1;
            baglanti.Close();
            this.Close();
        }

        private void urunekle_Load(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            filtrelericagir();
        }

        private void fiyat_TextChanged(object sender, EventArgs e)
        {

        }
        private void filtrelericagir()
        {
            olcutu.SelectedIndex = 0;
            OleDbCommand filtregetir = new OleDbCommand();
            filtregetir.Connection = baglanti;
            filtregetir.CommandText = "select * from filtre";
            OleDbDataReader filtrelerioku = filtregetir.ExecuteReader();
            while (filtrelerioku.Read())
            {

                turbilgi.Items.Add(filtrelerioku["tür"]);
                markabilgi.Items.Add(filtrelerioku["marka"]);

            }
            turbilgi.SelectedIndex = 0;
            markabilgi.SelectedIndex = 0;
        }
        private void fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //yeni Tür ekleme
            //yeni marka ekleme

        }
        private void turmarkaekle()
        {
 
        }


    }
}
