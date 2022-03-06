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
    public partial class yetkilerdeislem : Form
    {
        
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");
        string[] kodlar = new string[10];
        string[] personelisim = new string[10];
        int cekilenitut;
        public yetkilerdeislem()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            baglanti.Close();
            baglanti.Open();
            comboyaekle();
        }
        private void perliste()
        {
            OleDbCommand perliste = new OleDbCommand();
            perliste.Connection = baglanti;
            perliste.CommandText="";
           

         //   comboBox1.Items.Add
        }
        private void comboyaekle()
        {
            int i = 0;
             OleDbCommand yetkilistekomut = new OleDbCommand();
            yetkilistekomut.Connection = baglanti;
            yetkilistekomut.CommandText = "Select * From yetkiduzenle ";
            OleDbDataReader okuyetki = yetkilistekomut.ExecuteReader();
            while (okuyetki.Read())
            {

                comboBox2.Items.Add(okuyetki["personelkodu"]).ToString();
                kodlar[i] = (okuyetki["personelkodu"].ToString());
                
                urunadicek(i);

                comboBox1.Items.Add(personelisim[i]).ToString();
                
                //comboBox2.Items.Add(okuyetki[""])
            } 
            if (comboBox1.SelectedIndex == -1) comboBox1.SelectedIndex = 0;
        }
        private void urunadicek(int i)
        {
            OleDbCommand uruncek = new OleDbCommand();
            uruncek.Connection = baglanti;

            uruncek.CommandText = "Select * From Calisan where personelkodu="+kodlar[i]+"";
            OleDbDataReader uruncekoku = uruncek.ExecuteReader();
            while (uruncekoku.Read())
            {

                
               personelisim[i] = uruncekoku["personelisim"].ToString();
               

               
            }

        }
        private void yetkilistele()
        {

            OleDbCommand yetkilistekomut = new OleDbCommand();
            yetkilistekomut.Connection = baglanti;

            yetkilistekomut.CommandText = "Select * From yetkiduzenle where personelkodu=" + Convert.ToInt32(comboBox2.SelectedItem) + "";
            OleDbDataReader okuyetki = yetkilistekomut.ExecuteReader();
            while (okuyetki.Read())
            {


                if (okuyetki["giris"].ToString() == "0") girisyetki.SelectedIndex = 1; else girisyetki.SelectedIndex = 0;

                if (okuyetki["urunislem"].ToString() == "0") urunyetki.SelectedIndex = 1; else urunyetki.SelectedIndex = 0;
                if (okuyetki["personelislem"].ToString() == "0") personelyetki.SelectedIndex = 1; else personelyetki.SelectedIndex = 0;
                if (okuyetki["satisislem"].ToString() == "0") satisyetki.SelectedIndex = 1;else  satisyetki.SelectedIndex = 0;
               // personelyetki.Checked = Convert.ToBoolean(okuyetki["personelislem"]);
               // satisyetki.Checked = Convert.ToBoolean(okuyetki["urunsatis"]);



            }

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox2.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox2.DroppedDown = true;//comboboxı acık hale getirir
            comboBox1.DroppedDown = true;//comboboxı acık hale getirir

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != comboBox2.SelectedIndex)
            {
                comboBox2.SelectedIndex = comboBox1.SelectedIndex;
                
            }
          yetkilistele();
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != comboBox2.SelectedIndex)
            {
                comboBox1.SelectedIndex = comboBox2.SelectedIndex;
               
            }
            yetkilistele();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand yetkiduzenle = new OleDbCommand();
            yetkiduzenle.Connection=baglanti;
            string[] yetkitut=new string[10];
            if (girisyetki.SelectedIndex == 0) yetkitut[0] = "1"; else yetkitut[0] = "0";
            if (urunyetki.SelectedIndex == 0) yetkitut[1] = "1"; else yetkitut[1] = "0";
            if (satisyetki.SelectedIndex == 0) yetkitut[2] = "1"; else yetkitut[2] = "0";
            if (personelyetki.SelectedIndex == 0) yetkitut[3] = "1"; else yetkitut[3] = "0";
            yetkiduzenle.CommandText = "update yetkiduzenle set giris='" + yetkitut[0] + "',urunislem='" + yetkitut[1] + "',satisislem='" + yetkitut[2] + "',personelislem='" + yetkitut[3] +  "'where personelkodu=" + Convert.ToInt32(comboBox2.SelectedItem) + "";
            yetkiduzenle.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yetkilistele();
        }
    }
}
