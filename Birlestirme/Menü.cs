using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
namespace Birlestirme
{
    public partial class Menü : Form
    {
        public int panelsiras = -1;
        Form formismi;
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");



        public Menü()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            MessageBoxManager.Unregister();
            MessageBoxManager.Register();

        }





        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 asda = new Form1();
            // form
        }

        private void Menü_Load(object sender, EventArgs e)
        {
            this.Size = MaximumSize;
            cagirilanform.Size = this.Size;
            MessageBoxManager.Yes = "Programı Kapat";
            MessageBoxManager.No = "Oturumu Kapat";
            MessageBoxManager.Cancel = "Vazgeç";

            panel2.BringToFront();//panelin üste kalmasını sağlar
            baglanti.Close();
            baglanti.Open();
        }






        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 3)
            {
                urunekle cagirform = new urunekle();
                formismi = cagirform;
                panelsiras = 3;
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 1)
            {
                urunislem cagirform = new urunislem();
                formismi = cagirform;
                backgroundWorker1.RunWorkerAsync();

                panelsiras = 1;
            }
        }

        private void satışToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            giris giris = (giris)Application.OpenForms["giris"];


            if (panelsiras != 4 && giris.yetkiler[3])
            {
                satisislem cagirform = new satisislem();
                formismi = cagirform;
                backgroundWorker1.RunWorkerAsync();
                panelsiras = 4;

            }
            else { MessageBox.Show("Yetkiniz yok"); }

        }

        private void satisRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 5)
            {
                satisrapor cagirform = new satisrapor();
                formismi = cagirform;
                panelsiras = 5;
            }
        }

        private void personelİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 2)
            {
                perislem cagirform = new perislem();
                formismi = cagirform;
                backgroundWorker1.RunWorkerAsync();
                panelsiras = 2;

            }
        }

        private void adımlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giris cagirform = new giris();
            formismi = cagirform;

        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menü_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Menü_FormClosed(object sender, FormClosedEventArgs e)
        {


        }
        bool kapatiliyor = false;

        private void Menü_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!kapatiliyor)
            {
                giris giris = (giris)Application.OpenForms["giris"];
                DialogResult cikissoru = new DialogResult();
                cikissoru = MessageBox.Show("", "Çıkış", MessageBoxButtons.YesNoCancel);
                if (cikissoru == DialogResult.Yes) { kapatiliyor = true; giris.kapat(); }
                else if (cikissoru == DialogResult.No) { e.Cancel = true; giris.Show(); e.Cancel = false; }
                else { e.Cancel = true; }
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();//çıkıs yap butonu
        }
        private void paneldoldur()
        {
            formismi.Dock = DockStyle.Fill;
            formismi.TopLevel = false;
            formismi.FormBorderStyle = FormBorderStyle.None;


            cagirilanform.Controls.Add(formismi);
            formismi.Show();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (ActiveForm != null) { cagirilanform.Controls.Clear(); }


            if (cagirilanform.InvokeRequired)
            {
                cagirilanform.Invoke(new MethodInvoker(delegate
                {

                    formismi.Dock = DockStyle.Fill;
                    formismi.TopLevel = false;
                    formismi.FormBorderStyle = FormBorderStyle.None;
                    cagirilanform.Controls.Add(formismi);
                    formismi.Show();


                }));

            }
            else { MessageBox.Show("Bir hatayla karşılaşıldı hata kodu x101101"); }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cagirilanform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stoktaİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 9)
            {
                stokislem stokislem = new stokislem();
                formismi = stokislem;
                backgroundWorker1.RunWorkerAsync();
                panelsiras = 9;
            }
        }

        private void yetkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 10)
            {
                yetkilerdeislem yetkilerdeislem = new yetkilerdeislem();
                formismi = yetkilerdeislem;
                backgroundWorker1.RunWorkerAsync();
                panelsiras = 10;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
