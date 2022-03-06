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
using System.Threading;

namespace Birlestirme
{
    public partial class urunislem : Form
    {
        int abc = 0;
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");
       
        bool sayiharf;public int stokkodunubul, tutulacak;
        int stokcesit; bool menuackapa = false;


        public urunislem()
        {
            InitializeComponent(); CheckForIllegalCrossThreadCalls = false;
        }
        void ilkharfbuyuk(TextBox texbox)
        {
            if (texbox.TextLength > 0)
            {
                texbox.Text = char.ToUpper(texbox.Text[0]).ToString() + texbox.Text.Substring(1);
                texbox.SelectionStart = texbox.TextLength;
            }
        }
        public void kodsira()
        {
            listeurun.Rows.Clear();
            //baglanti.Open();
          


            for (int i = 1; ; i++)
            {

                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;
                listeurun.Sort(listeurun.Columns[0], ListSortDirection.Ascending);
                kom.CommandText = "Select * From Ürün where Kodu like " + i + "";
                OleDbDataReader oku2 = kom.ExecuteReader();

                if (oku2.Read())
                {




                }
                else { stokkodunubul = i; break; }
            }


            //baglanti.Close();
        }
        private void listelenecek()
        {
            
            
                listeurun.Rows.Clear();

                // listView1.Items.Clear();
                
                OleDbCommand listelekomut = new OleDbCommand();
                listelekomut.Connection = baglanti;
                listelekomut.CommandText = "Select * From Ürün";
                OleDbDataReader listeoku = listelekomut.ExecuteReader();
                while (listeoku.Read())
                {

                    int satir = listeurun.Rows.Add();
                    listeurun.Rows[satir].Cells[0].Value = listeoku["Kodu"];
                    listeurun.Rows[satir].Cells[1].Value = listeoku["Ürün"].ToString();
                    listeurun.Rows[satir].Cells[2].Value = listeoku["Fiyat"].ToString();
                    listeurun.Rows[satir].Cells[4].Value = listeoku["TÜR"].ToString();
                    listeurun.Rows[satir].Cells[5].Value = listeoku["BOYUT"].ToString();
                    listeurun.Rows[satir].Cells[6].Value = listeoku["AĞIRLIK"].ToString();
                    //listeurun.Rows[satir].Cells[7].Value = oku["BİLGİ"].ToString();
                    listeurun.Rows[satir].Cells[3].Value = "Yok";


                }
                stokcesit++;


                label11.Text = listeurun.Rows.Count.ToString();
               
                listeurun.Sort(listeurun.Columns[0], ListSortDirection.Ascending);
            
            //baglanti.Close();
        }
        private void temizle()
        {
            urunad.Clear(); stokbilgi.Clear(); fiyat.Clear(); stokkodu.Clear(); turbilgi.Clear(); agirlik.Clear(); boyut.Clear();
            stokkodu.Text = ""; duzenlebutton.Enabled = silbutton.Enabled   = false; listeurun.ClearSelection();
        }
        private void verilericek()
        {
            //baglanti.Open();
            OleDbCommand vericekkomut = new OleDbCommand();
            vericekkomut.Connection = baglanti;

            vericekkomut.CommandText = "Select *from Ürün where Kodu=" + Convert.ToInt16(stokkodu.Text) + "";
            OleDbDataReader vericekoku = vericekkomut.ExecuteReader();
            while (vericekoku.Read())
            {

                urunad.Text = vericekoku["Ürün"].ToString();

                stokbilgi.Text = vericekoku["Bilgi"].ToString();
                agirlik.Text = vericekoku["AĞIRLIK"].ToString();
                boyut.Text = vericekoku["BOYUT"].ToString();
                fiyat.Text = vericekoku["Fiyat"].ToString();
                turbilgi.Text = vericekoku["TÜR"].ToString();
            }
            //baglanti.Close();

        }




        private void Form11_Load(object sender, EventArgs e)
        {
           
            baglanti.Close();
            baglanti.Open();
            listeurun.Enabled = true;

            backgroundWorker1.RunWorkerAsync();
            temizle();
          
        }


        private void arama_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            abc++;
           // if (abc == 3)
            {
                ilkharfbuyuk(arama);
                listeurun.Rows.Clear();
                //baglanti.Open();
                OleDbCommand aramakomut = new OleDbCommand();
                aramakomut.Connection = baglanti;

                //    if ()komut.CommandText = "Select * From Ürün where Ürün like '%"+textBox1.Text+"%'";

                if (sayiharf)
                {
                    aramakomut.CommandText = "Select * From Ürün where Ürün like '%" + arama.Text + "%'";
                }
                else { aramakomut.CommandText = "Select * From Ürün where Kodu like '%" + arama.Text + "%'"; }

                OleDbDataReader aramaoku = aramakomut.ExecuteReader();

                while (aramaoku.Read())
                {



                    int satir = listeurun.Rows.Add();

                    listeurun.Rows[satir].Cells[0].Value = aramaoku["Kodu"];
                    listeurun.Rows[satir].Cells[1].Value = aramaoku["Ürün"].ToString();
                    listeurun.Rows[satir].Cells[2].Value = aramaoku["Fiyat"].ToString();
                    listeurun.Rows[satir].Cells[3].Value = "Yok";
                    listeurun.Rows[satir].Cells[4].Value = aramaoku["TÜR"].ToString();
                    listeurun.Rows[satir].Cells[5].Value = aramaoku["BOYUT"].ToString();
                    listeurun.Rows[satir].Cells[6].Value = aramaoku["AĞIRLIK"].ToString();
                    //listeurun.Rows[satir].Cells[7].Value = oku["BİLGİ"].ToString();
                    
                }
                //baglanti.Close();
                listeurun.Sort(listeurun.Columns[0], ListSortDirection.Ascending);

                listeurun.ClearSelection();
                timer1.Enabled = false;
                pictureBox1.Visible = false;

            }





            /*backgroundWorker2.RunWorkerAsync();
            timer1.Enabled = true;
            abc = 0;*/
         
            
           
           
               // abc = 0;

        
        }

        
        private void stokkodu_TextChanged(object sender, EventArgs e)
        {
         
           
           
           
            ilkharfbuyuk(urunad); ilkharfbuyuk(agirlik); ilkharfbuyuk(stokbilgi); ilkharfbuyuk(boyut); ilkharfbuyuk(turbilgi); ilkharfbuyuk(ek);
            
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
           // baglanti.Open();
            OleDbCommand silkomut = new OleDbCommand();
            silkomut.Connection = baglanti;
            if (listeurun.CurrentRow.Cells[0].Value != null)
            {
                tutulacak = listeurun.CurrentRow.Cells[0].RowIndex;
                silkomut.CommandText = "delete from ÜRÜN where Kodu=" + listeurun.CurrentRow.Cells[0].Value.ToString() + "";
            }
            if (listeurun.RowCount > 5) { listeurun.FirstDisplayedScrollingRowIndex = tutulacak - 1; }
            silkomut.ExecuteNonQuery();
            //baglanti.Close();
            silbutton.Enabled = false;
            listelenecek();
            temizle();

            //listeurun.Rows[tutulacak].Selected = true;//Satır işaretleme
         /*   if (tutulacak != listeurun.RowCount)
            {
                // listeurun.Rows[tutulacak].Selected = false;
            //    listeurun.FirstDisplayedScrollingRowIndex = tutulacak;

            }
            else
            {
                if (tutulacak != 0)
                {
                    // listeurun.Rows[tutulacak-1].Selected = true;
                 //   listeurun.FirstDisplayedScrollingRowIndex = tutulacak - 1;
                }
            }//İndexe yönelme*/
        }

        private void duzenlebutton_Click(object sender, EventArgs e)
        {
            if (urunad.Text != "" && stokkodu.Text != "")
            {

                //baglanti.Open();
                OleDbCommand duzenlekomut = new OleDbCommand();
                duzenlekomut.Connection = baglanti;
                duzenlekomut.CommandText = "update  ÜRÜN set Ürün='" + urunad.Text + "',TÜR='" + turbilgi.Text + "',AĞIRLIK='" + agirlik.Text + "',BOYUT='" + boyut.Text + "',Bilgi='" + ek.Text + "',Fiyat='" + fiyat.Text + "" + "'where Kodu=" + stokkodu.Text + "";//hata alınırsa                 duzenlekomut.CommandText = "update  ÜRÜN set Ürün='" + urunad.Text + "',TÜR='" + turbilgi.Text + "',AĞIRLIK='" + agirlik.Text + "',BOYUT='" + boyut.Text + "',Bilgi='" + ek.Text + "',Fiyat='" + fiyat.Text +"" + "'where Kodu=" + stokkodu.Text + "";
                duzenlekomut.ExecuteNonQuery();
                //baglanti.Close();
                silbutton.Enabled = false;
                listelenecek();
                duzenlebutton.Enabled = false;
            //    int sayi = listeurun.Rows.Count;
             //   listeurun.Rows[sayi - 1].Selected = true;//Satır işaretleme
             //   listeurun.FirstDisplayedScrollingRowIndex = sayi - 1;
                duzenlebutton.Enabled = false;
                panel1.Visible = false;
                button3.Visible = false;

            }
           
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            listelenecek();
        }

        private void listeurun_Click(object sender, EventArgs e)
        {
            if (listeurun.SelectedRows.Count != 0)
            {
                silbutton.Enabled = true;
                duzenlebutton.Enabled = true;
                stokkodu.Text = listeurun.CurrentRow.Cells[0].Value.ToString();
                button1.Enabled = true;
                verilericek();
               
                duzenlebutton.Enabled = true;
               
            }
        }

        private void temmizle_Click(object sender, EventArgs e)
        {
            temizle();  duzenlebutton.Enabled = false;
            panel1.Visible = false; button3.Visible = false;
        }

        private void arama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (arama.Text == "")
            {
                if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57 && e.KeyChar != (char)Keys.Back) sayiharf = false;
                else if (e.KeyChar != (char)Keys.Back) sayiharf = true;
            }
        }

       

       

        private void button7_Click(object sender, EventArgs e)
        {
            perislem per = new perislem();
            per.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* pictureBox1.Visible = true;
            abc++;
            if (abc == 3)
            {
                ilkharfbuyuk(arama);
                listeurun.Rows.Clear();
                //baglanti.Open();
                komut.Connection = baglanti;

                //    if ()komut.CommandText = "Select * From Ürün where Ürün like '%"+textBox1.Text+"%'";

                if (sayiharf)
                {
                    komut.CommandText = "Select * From Ürün where Ürün like '%" + arama.Text + "%'";
                }
                else { komut.CommandText = "Select * From Ürün where Kodu like '%" + arama.Text + "%'"; }

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {



                    int satir = listeurun.Rows.Add();
                   
                    listeurun.Rows[satir].Cells[0].Value = oku["Kodu"];
                    listeurun.Rows[satir].Cells[1].Value = oku["Ürün"].ToString();
                    listeurun.Rows[satir].Cells[2].Value = oku["Fiyat"].ToString();
                    listeurun.Rows[satir].Cells[4].Value = oku["TÜR"].ToString();
                    listeurun.Rows[satir].Cells[5].Value = oku["BOYUT"].ToString();
                    listeurun.Rows[satir].Cells[6].Value = oku["AĞIRLIK"].ToString();
                    //listeurun.Rows[satir].Cells[7].Value = oku["BİLGİ"].ToString();
                    listeurun.Rows[satir].Cells[3].Value = "Yok";
                }
                //baglanti.Close();
                listeurun.Sort(listeurun.Columns[0], ListSortDirection.Ascending);
                
                listeurun.ClearSelection();
                timer1.Enabled = false;
                pictureBox1.Visible = false;
                
            }*/
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listeurun.CurrentRow.Cells[0].Value != null)
            {
                panel1.Visible = true; button3.Visible = true; temmizle.Visible = true; temmizle.Enabled = true;
            }
            else
            {
                MessageBox.Show("");
 
            }
        }
        int panelsiras = -1;
        private void button2_Click(object sender, EventArgs e)
        {
            
               
                urunekle urunekle = new urunekle();
                urunekle.ShowDialog();
                baglanti.Close();
                baglanti.Open();
                listelenecek();
                
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
     
            listelenecek();

            

            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listeurun.Enabled = true;
            listeurun.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle(); panel1.Visible = false; 
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void listeurun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
              if (listeurun.InvokeRequired)
            {
                listeurun.Invoke(new MethodInvoker(delegate
                { listelenecek();
                }));

            }
              else { MessageBox.Show("Bir hatayla karşılaşıldı hata kodu x101101"); }
        }
       
    }
}
