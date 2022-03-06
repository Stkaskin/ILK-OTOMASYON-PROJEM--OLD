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
    public partial class giris : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");
        OleDbCommand komut = new OleDbCommand(); OleDbCommand komutyetki = new OleDbCommand();
       

        public giris()
        {
            InitializeComponent();
        }
        public bool yetki; string[] yetkiisim =new string[25]; public bool[] yetkiler = new bool[25];
        private void yetkileriisimlendir()
        {
             yetkiisim[0] = "Giriş";
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
          

        }


        private void giris_Load(object sender, EventArgs e)
        {
            //Menü menü = (Menü)Application.OpenForms["Menü"];
            
            yetkileriisimlendir();// baglanti.Open();
        }
        private void girissorgu()
        {
            int personelkodu = -1;//hatayla karşılaşmamak için yapıldı
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                baglanti.Open();// bağlanti acılır 
                komut.Connection = baglanti;//komut verilir
                komut.CommandText = "SELECT * FROM Calisan where personelkodu=" + textBox1.Text + " AND sifre='" + textBox2.Text + "'";
                OleDbDataReader oku = komut.ExecuteReader();//komut okulur
                while (oku.Read())
                {
                    personelkodu = Convert.ToInt32(oku["personelkodu"]);
                    

                }
                //baglanti.Close();
                if (personelkodu != -1) yetkileriaktar(personelkodu);
                else { MessageBox.Show("Kullanıcı Bilgileri Yanlış"); baglanti.Close(); }//boyle bilgi yoksa connection  kapatilir 
            }

        }
        private void yetkicikis()
        {
            yetkiler[0] = yetkiler[1] = yetkiler[2] = false;
        }
        private void yetkileriaktar(int personelkodu)
        {

            yetkicikis();
            komutyetki.Connection = baglanti;
            komutyetki.CommandText = "Select * From yetkitablosu where personelkodu="+personelkodu+"";
            
            OleDbDataReader okuyetki = komutyetki.ExecuteReader();
            while (okuyetki.Read())
            {
               

                yetkiler[0] = Convert.ToBoolean(okuyetki["giris"]);
                yetkiler[1] = Convert.ToBoolean(okuyetki["urunara"]);
                yetkiler[2] = Convert.ToBoolean(okuyetki["urunekle"]);
               yetkiler[3]=Convert.ToBoolean(okuyetki["urunsatis"]);
               
                
                
            }
      //baglanti.Close();
      girisyap();

            
        }
        private void girisyap()
        {
            if (yetkiler[0])
            {
             //   Menü menü = new Menü();
                MessageBox.Show("Giriş Yapıldı");
                Menü menü = new Menü();
                menü.Show();
                this.Hide();

            }
            else { MessageBox.Show("Giriş Kısıtlaması Vardır "); }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            girissorgu();//giriş için bilgiler kontrol edilir (yorumbilgi1)
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        public void kapat()
    
        {

            this.Close();
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yetkiler[0] = true; girisyap();
        }
    }
}
