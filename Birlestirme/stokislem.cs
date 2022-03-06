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
    public partial class stokislem : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hırdavat Ürün.accdb");
        public stokislem()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            listenecek();

        }
        private void listenecek()
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
                listeurun.Rows[satir].Cells[2].Value = listeoku["marka"].ToString();
                listeurun.Rows[satir].Cells[3].Value = listeoku["stokdurum"].ToString();
               
                //listeurun.Rows[satir].Cells[7].Value = oku["BİLGİ"].ToString();
              


            }
           


           

            listeurun.Sort(listeurun.Columns[0], ListSortDirection.Ascending);
        }
        public string[] bilgigönder = new string[9]; public bool gironay = false;
        private void button7_Click(object sender, EventArgs e)
        {
            if (listeurun.SelectedRows.Count != 0)
            {
               
                 bilgigönder[0]= listeurun.CurrentRow.Cells[0].Value.ToString();
                 bilgigönder[1] = listeurun.CurrentRow.Cells[1].Value.ToString();
                 bilgigönder[2] = listeurun.CurrentRow.Cells[2].Value.ToString();
                 bilgigönder[3] = listeurun.CurrentRow.Cells[3].Value.ToString();
                
                 stokgircik stokgircik = new stokgircik();
                 stokgircik.ShowDialog();
                
                 if (gironay)
                 {
                     OleDbCommand stokgirkomut = new OleDbCommand();
                     stokgirkomut.Connection = baglanti;
                     int cevir;
                     if (bilgigönder[3] != "")
                     {
                         cevir = Convert.ToInt32(bilgigönder[3]);
                     }
                     else { cevir =0;}
                     cevir += Convert.ToInt32(bilgigönder[4]);

                  

                     stokgirkomut.CommandText = "update  ÜRÜN set stokdurum='" + cevir + "" + "'where Kodu=" + bilgigönder[0] + "";
                     stokgirkomut.ExecuteNonQuery();
                     gironay = false;
                     listenecek();
                 }

            }
        }
    }
}
