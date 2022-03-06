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
    public partial class perislem : Form
    {

        public string  bilgi2, bilgi3, bilgi4, bilgi5, bilgi6;
        public int bilgi1;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");
        OleDbCommand komut = new OleDbCommand();
        bool sayiharf; int  tutulacak;
        int calisansayisi;



        public perislem()
        {
            InitializeComponent();
        }

     
        private void listelenecek()
        {
            personellistesi.Rows.Clear();

            // listView1.Items.Clear();

          //baglanti.Open();
            OleDbCommand listekomut = new OleDbCommand();
            listekomut.Connection = baglanti;
            listekomut.CommandText = "Select * From Calisan";
            OleDbDataReader listeoku = listekomut.ExecuteReader();
            while (listeoku.Read())
            {

                int satir = personellistesi.Rows.Add();
                personellistesi.Rows[satir].Cells[0].Value = listeoku["personelkodu"];
                personellistesi.Rows[satir].Cells[1].Value = listeoku["personelisim"].ToString();
                //  dataGridView1.Rows[satir].Cells[2].Value = oku["Fiyat"].ToString();

            }
            calisansayisi++;


            label11.Text = personellistesi.Rows.Count.ToString();
            //baglanti.Close();
            personellistesi.Sort(personellistesi.Columns[0], ListSortDirection.Ascending);
        }
        private void verilericek()
        {
            //baglanti.Open();
            OleDbCommand vericekkomut = new OleDbCommand();
            vericekkomut.Connection = baglanti;

            vericekkomut.CommandText = "Select *from Calisan where personelkodu=" + bilgi1 + "";
            OleDbDataReader vericekoku = vericekkomut.ExecuteReader();
            while (vericekoku.Read())
            {


                bilgi2 = vericekoku["personelisim"].ToString();
                bilgi3 = vericekoku["personelcinsiyet"].ToString();
             
              //  bilgi7 = oku["TÜR"].ToString();
               
              //  turbilgi.Text = oku["TÜR"].ToString();
            }
            isimlabel.Text = bilgi2;
            numaralabel.Text = bilgi1.ToString();
            //baglanti.Close();

        }



       private void yenikisiekleonay()
        {

           

            //baglanti.Open();
            calisansayisi = personellistesi.Rows.Count + 1;
            OleDbCommand eklekomut = new OleDbCommand();
            eklekomut.Connection = baglanti;
         
           
            eklekomut.CommandText = "insert into Calisan (personelkodu,personelisim,personelcinsiyet) values (" + bilgi1 + ",'" + bilgi2 + "','" + bilgi3 + "')";
            eklekomut.ExecuteNonQuery();

            //baglanti.Close();
            listelenecek();
            temizle();
           
            personellistesi.Sort(personellistesi.Columns[0], ListSortDirection.Ascending);
            personellistesi.FirstDisplayedScrollingRowIndex = personellistesi.Rows.Count - 1;
            personellistesi.Rows[tutulacak].Selected = false;
         


        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            temizle(); temmizle.Enabled = false;
        }
        private void temizle()
        {
            
        }
        public bool perdegonay = false;
        private void duzenlebutton_Click(object sender, EventArgs e)
        {
            personelduzenle personelduzenle = new personelduzenle();
            personelduzenle.ShowDialog();
            if (perdegonay == true)
            {
               
                //baglanti.Open();
                OleDbCommand duzenlekomut = new OleDbCommand();
                duzenlekomut.Connection = baglanti;
                duzenlekomut.CommandText = "update  Calisan set personelisim='" + bilgi2 + "',personelcinsiyet='" + bilgi3 + "'where personelkodu=" + bilgi1 + "";
                duzenlekomut.ExecuteNonQuery();
                //baglanti.Close();
                silbutton.Enabled = false;
                listelenecek();
                duzenlebutton.Enabled = false;
                int sayi = personellistesi.Rows.Count;
                personellistesi.Rows[sayi - 1].Selected = true;//Satır işaretleme
                personellistesi.FirstDisplayedScrollingRowIndex = sayi - 1;
                duzenlebutton.Enabled = true;
                perdegonay = false;
                MessageBox.Show("Değiştirildi");


            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listelenecek();
        }
        
        private void silbutton_Click(object sender, EventArgs e)
        {
            

            //baglanti.Open();
            OleDbCommand silkomut = new OleDbCommand();
            silkomut.Connection = baglanti;
            if (personellistesi.CurrentRow.Cells[0].Value != null)
            {
                tutulacak = personellistesi.CurrentRow.Cells[0].RowIndex;
                silkomut.CommandText = "delete from Calisan where personelkodu=" + personellistesi.CurrentRow.Cells[0].Value.ToString() + "";
                silkomut.ExecuteNonQuery();
               
            }
            if (personellistesi.RowCount > 5) { personellistesi.FirstDisplayedScrollingRowIndex = tutulacak - 1; }
            //baglanti.Close();
            silbutton.Enabled = false;
            listelenecek();
            personellistesi.ClearSelection();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ilkharfbuyuk(textBox1);

            personellistesi.Rows.Clear();
            //baglanti.Open();
            OleDbCommand arakomut = new OleDbCommand();
            arakomut.Connection = baglanti;

            //    if ()komut.CommandText = "Select * From Ürün where Ürün like '%"+textBox1.Text+"%'";

            if (sayiharf)
            {
                arakomut.CommandText = "Select * From Calisan where personelisim like '%" + textBox1.Text + "%'";
            }
            else 
            {
                arakomut.CommandText = "Select * From Calisan where personelkodu like '%" + textBox1.Text + "%'"; 
            }

            OleDbDataReader araoku = arakomut.ExecuteReader();

            while (araoku.Read())
            {



                int satir = personellistesi.Rows.Add();
                personellistesi.Rows[satir].Cells[0].Value = araoku["personelkodu"];
                personellistesi.Rows[satir].Cells[1].Value = araoku["personelisim"].ToString();
                //   dataGridView1.Rows[satir].Cells[2].Value = oku["Fiyat"].ToString();
            }
            personellistesi.Sort(personellistesi.Columns[0], ListSortDirection.Ascending);
            //baglanti.Close();
            personellistesi.ClearSelection();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "")
            {
                if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57 && e.KeyChar != (char)Keys.Back) sayiharf = false;
                else if (e.KeyChar != (char)Keys.Back) sayiharf = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Personel Kodu Otomatik Atanır \n Personel Adını Girerek Kayıt Yapabilirsiniz\nArama için Personel Kodu Veya\n Ürün ismi giriniz.");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (personellistesi.SelectedRows.Count != 0)
            {
                silbutton.Enabled = true;
                duzenlebutton.Enabled = true;
                bilgi1 = Convert.ToInt32(personellistesi.CurrentRow.Cells[0].Value);

                verilericek();
                temmizle.Enabled = true;
                duzenlebutton.Enabled = true;
                eklebutton.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
       //     //baglanti.Open();

            OleDbCommand tabloac = new OleDbCommand();
            string strTemp = " [İsim] Text, [Soyisim] Text ";
            tabloac.Connection = baglanti;
            string isimsel = "Yetki" + 1;
            tabloac.CommandText = "create table isimsel(" + strTemp + ")";
            tabloac.ExecuteNonQuery();
         //   //baglanti.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        void kodsira()
        {
          
         //   //baglanti.Open();
          

            for (int i = 1; ; i++)
            {

                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;
                personellistesi.Sort(personellistesi.Columns[0], ListSortDirection.Ascending);
                kom.CommandText = "Select * From Calisan where personelkodu like " + i + "";
                OleDbDataReader oku2 = kom.ExecuteReader();

                if (oku2.Read())
                {




                }
                else { bilgi1 = i ;  break; }
            }


            //baglanti.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("datagridviewde boş yere clickleyip sil basınca hata veriyor .");
        }

        private void ek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                eklebutton.PerformClick();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void ilkharfbuyuk(TextBox texbox)
        {
            if (texbox.TextLength > 0)
            {
                texbox.Text = char.ToUpper(texbox.Text[0]).ToString() + texbox.Text.Substring(1);
                texbox.SelectionStart = texbox.TextLength;
            }
        }

        private void perislem_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show("Yapım işlemi tamamlanmadi");
         
            
            baglanti.Close();
            
            personellistesi.ClearSelection();
            baglanti.Open();
            temizle();
            listelenecek();
        }

        private void stokkodu_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Personel Kodu Otomatik Atanır \n Personel Adını Girerek Kayıt Yapabilirsiniz\nArama için Personel Kodu Veya\n Ürün ismi giriniz.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında!!!");
        }

       

      
        public bool ekleonay = false;
        private void eklebutton_Click(object sender, EventArgs e)
        {
            personellistesi.ClearSelection();
            kodsira();
            yenipersonelekle yenipersonelekle = new yenipersonelekle();
            yenipersonelekle.ShowDialog();
            

            if (ekleonay)
            {
                ekleonay = false;
                yenikisiekleonay();
            }
            listelenecek();
            personellistesi.ClearSelection();
        }
      

       
       
    }
}
