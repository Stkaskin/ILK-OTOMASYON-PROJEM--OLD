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
    public partial class satisislem : Form
    {
        urunislem urunislem = (urunislem)Application.OpenForms["urunislem"];
        Satıssoru satissoru = (Satıssoru)Application.OpenForms["Satıssoru"];
        satisrapor satisraporu =(satisrapor)Application.OpenForms["satisrapor"];
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");
        bool fitresarti = true;
        string tur, marka;
        int endusukfiyat, enyuksekfiyat;

   
       
        public string urunismigönder, stokkodugönder,fiyatgönder;
        public satisislem()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            fitrelericagir();
           
            backgroundWorker1.RunWorkerAsync();
           
            
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void urun1_Click(object sender, EventArgs e)
        {
            Satıssoru satis = new Satıssoru();
            satis.FormBorderStyle = FormBorderStyle.None;
           // satis.textBox1.Text = "1";
            satis.ShowDialog();
            
           
          
        }
        string ürünismi = "";
        int satir = 0, sütün = 0, feg = 0;
        private void urunkadarbutton()
        {
           
           kodsirasinibul();
            for (int names = 1; names < stokkodunubul;names++ )
            {
                 Button  btn = new  Button();
                btn.Name = names.ToString() ;
                ürünismibul(names);
                stokkodugönder = btn.Name;
                btn.Text = ürünismi;
                urunismigönder = ürünismi;
                btn.Location = new Point(satir * 70, sütün * 60);
                btn.Width = 60;
                btn.Height = 60;
                tabPage1.Controls.Add(btn);
                if (satir == 5) { satir = 0; sütün++; }
                else { satir++; }
                btn.Click += btnn;//değiştirildi btnn;
                feg++;
            }

        }
        private void ürünismibul (int names)
        {
            OleDbCommand urunismibulkomut = new OleDbCommand();
            urunismibulkomut.Connection = baglanti;
          
                


                urunismibulkomut.CommandText = "Select *from Ürün where Kodu=" + names + "";
                OleDbDataReader urunismibuloku = urunismibulkomut.ExecuteReader();
                while (urunismibuloku.Read())
                {

                    ürünismi = urunismibuloku["Ürün"].ToString();
                    fiyatgönder = urunismibuloku["Fiyat"].ToString();

                }
             //  baglanti.Close();
            
       
        }
        int bulunanlistedeger = -1; bool buldumu;
        private void listeara(string aranacakdeger)
        {
            for (int i = 0; i < listeurun.Items.Count; i++)
            {
                if (listeurun.Items[i].SubItems[0].Text == aranacakdeger)
                {
                    bulunanlistedeger = i; buldumu = true;  break;
                }
                else 
                {
                    buldumu = false;
                }
            }
        }
        int stokkodunubul;
        private void btnn(object sender, EventArgs e)
        {
            Satıssoru satissoru = new Satıssoru();
           satissoru.ShowDialog();
            if (satissoru.satisonay)
            {
                int tutar;
               // baglanti.Open();
                OleDbCommand buttonolusturkomut = new OleDbCommand();
                buttonolusturkomut.Connection = baglanti;


                buttonolusturkomut.CommandText = "Select *from Ürün where Kodu=" + ((Button)sender).Name + "";
                OleDbDataReader oku = buttonolusturkomut.ExecuteReader();
                while (oku.Read())
                {

                    
                    int satirsal = listeurun.Items.Count;
                    listeara(((Button)sender).Text);
                    
                    if (buldumu)
                    {
                       
                        buldumu = false;
                        int addet = Convert.ToInt32(listeurun.Items[bulunanlistedeger].SubItems[2].Text);

                        addet += satissoru.adet;
                        listeurun.Items[bulunanlistedeger].SubItems[2].Text = addet.ToString();
                        tutar = Convert.ToInt32(listeurun.Items[bulunanlistedeger].SubItems[1].Text) * Convert.ToInt32(listeurun.Items[bulunanlistedeger].SubItems[2].Text);
                        listeurun.Items[bulunanlistedeger].SubItems[3].Text = tutar.ToString();
                    }
                    else
                    {
                        listeurun.Items.Add(oku["Ürün"].ToString());
                        listeurun.Items[satirsal].SubItems.Add(oku["Fiyat"].ToString());


                        listeurun.Items[satirsal].SubItems.Add(satissoru.adet.ToString());

                         tutar = Convert.ToInt32(listeurun.Items[satirsal].SubItems[1].Text) * Convert.ToInt32(listeurun.Items[satirsal].SubItems[2].Text);
                         listeurun.Items[satirsal].SubItems.Add(tutar.ToString());
                    }
                    tutarhesapla();

                       
                   

                }
               // baglanti.Close();
            }
            satissoru.satisonay = false;
        }
        private void tutarhesapla()
        {
            int toplamtutar=0;
            for (int i =0;i<listeurun.Items.Count;i++)
            {
                 toplamtutar+=Convert.ToInt32(listeurun.Items[i].SubItems[3].Text);
            }
            label2.Text = toplamtutar.ToString();
        }

        public void kodsirasinibul()
        {
      
            
            //baglanti.Open();
           // kodsira.Connection = baglanti;



            for (int i = 1; ; i++)
            {

                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;

                kom.CommandText = "Select * From Ürün where Kodu like " + i + "";
                OleDbDataReader kodsiraoku = kom.ExecuteReader();

                if (kodsiraoku.Read())
                {




                }
                else { stokkodunubul = i; break; }
            }


          //  baglanti.Close();
        }


      
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onaylandı Satış Raporuna Eklendi-- Veritabanı>>SatısRaporu Oluşturulacak");
            listeurun.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listeurun.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (listeurun.SelectedIndices.Count > 0) 
                listeurun.Items.RemoveAt(listeurun.SelectedItems[0].Index);
            

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void button17_Click()
        {
            
        }
        private void butonn(Button btn)
        {
            tabPage1.Controls.Add(btn);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            kodsirasinibul();
            progressBar1.Value += 50;
            for (int names = 1; names < stokkodunubul; names++)
            {
              
       
                if (tabPage1.InvokeRequired)
                {
                    tabPage1.Invoke(new MethodInvoker(delegate
                    {

                        backgroundWorker1.ReportProgress(50 / stokkodunubul);
                        Button btn = new Button();
                        btn.Name = names.ToString();
                        ürünismibul(names);
                        stokkodugönder = btn.Name;
                        btn.Text = ürünismi;
                        urunismigönder = ürünismi;
                       
                        btn.Location = new Point(satir * 70, sütün * 60);
                        btn.Width = 60;
                        btn.Height = 60;
                        butonn(btn);

                        if (satir == 5) { satir = 0; sütün++; }
                        else { satir++; }
                        btn.Click += btnn;
                        feg++;
                    }));
                    
                }
                else { MessageBox.Show("Bir hatayla karşılaşıldı hata kodu x101101"); }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
            progressBar1.Visible = false;
            label3.Visible = false;
            progressBar1.Value = 100;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value += e.ProgressPercentage;
        }
        private void fitrelericagir()
        {
            OleDbCommand filtregetir = new OleDbCommand();
            filtregetir.Connection=baglanti;
            filtregetir.CommandText="select * from filtre";
            OleDbDataReader filtrelerioku = filtregetir.ExecuteReader();
            while (filtrelerioku.Read()) 
            {
               
                turcombo.Items.Add(filtrelerioku["tür"]);
                markacombo.Items.Add(filtrelerioku["marka"]);
                
            }
            turcombo.SelectedIndex = 0;
            markacombo.SelectedIndex = 0;
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Satıssoru satissoru = new Satıssoru();
                satissoru.ShowDialog();
                if (satissoru.satisonay)
                {
                    int tutar;
                    OleDbCommand kodsira = new OleDbCommand();
                    kodsira.Connection = baglanti;


                    kodsira.CommandText = "Select *from Ürün where Kodu=" + ((Button)sender).Name + "";
                    OleDbDataReader kodsiraoku = kodsira.ExecuteReader();
                    while (kodsiraoku.Read())
                    {
                        //filtre sartiburaya uygun olabilir.

                        int satirsal = listeurun.Items.Count;
                        listeara(((Button)sender).Text);

                        if (buldumu)
                        {

                            buldumu = false;
                            int addet = Convert.ToInt32(listeurun.Items[bulunanlistedeger].SubItems[2].Text);

                            addet += satissoru.adet;
                            listeurun.Items[bulunanlistedeger].SubItems[2].Text = addet.ToString();
                            tutar = Convert.ToInt32(listeurun.Items[bulunanlistedeger].SubItems[1].Text) * Convert.ToInt32(listeurun.Items[bulunanlistedeger].SubItems[2].Text);
                            listeurun.Items[bulunanlistedeger].SubItems[3].Text = tutar.ToString();
                        }
                        else
                        {
                            listeurun.Items.Add(kodsiraoku["Ürün"].ToString());
                            listeurun.Items[satirsal].SubItems.Add(kodsiraoku["Fiyat"].ToString());


                            listeurun.Items[satirsal].SubItems.Add(satissoru.adet.ToString());

                            tutar = Convert.ToInt32(listeurun.Items[satirsal].SubItems[1].Text) * Convert.ToInt32(listeurun.Items[satirsal].SubItems[2].Text);
                            listeurun.Items[satirsal].SubItems.Add(tutar.ToString());
                        }
                        tutarhesapla();




                    }
                    //baglanti.Close();
                }
                satissoru.satisonay = false;
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = (hScrollBar1.Value).ToString();
            hScrollBar2.Minimum = hScrollBar1.Value ;
            label9.Text = (hScrollBar2.Value).ToString();
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
          label9.Text = (hScrollBar2.Value).ToString();
        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {

            if (filtrepanel.Visible) { filtrepanel.Visible = false;  }
            else { filtrepanel.Visible = true; }
            //visiblechanged event:
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            fitresarti = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                filtrepanel.Visible = true;
              panel2.Visible = false;
                panel1.Location = new Point(430, 20);
                panel1.Visible = true;
            }
            else { panel1.Visible = false; panel2.Visible = true; }
            if (filtrepanel.Visible) filtrepanel.Visible = false;
        }

        private void filtrepanel_VisibleChanged(object sender, EventArgs e)
        {
            if (!filtrepanel.Visible) filtrebutton.Text = "Filtrele";
            else { filtrebutton.Text = "Filtre Kapat"; markacombo.SelectedIndex = 0; turcombo.SelectedIndex = 0; hScrollBar1.Value = 0; hScrollBar2.Value = 1000; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Location = hScrollBar1.Location;
            textBox2.Location = hScrollBar2.Location;

            if (hScrollBar1.Visible) { hScrollBar1.Visible = hScrollBar2.Visible = false; textBox1.Visible = textBox2.Visible = true; }
            else { hScrollBar1.Visible = hScrollBar2.Visible = true; textBox1.Visible = textBox2.Visible = false; }
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1000";
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            label8.Text = textBox1.Text;
            label9.Text = textBox2.Text;

        }

       

       

       
    }
}
// tabPage1.BackgroundImage = Image.FromFile("Infinity200.gif");  resim ekle debugda     tabPage1.BackgroundImage = null;resmi kaldir