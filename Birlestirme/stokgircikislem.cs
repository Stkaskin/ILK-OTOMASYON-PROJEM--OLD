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
    public partial class stokgircik : Form
    {
        stokislem stokislem = (stokislem)Application.OpenForms["stokislem"];
        public stokgircik()
        {
            InitializeComponent();
        }

        private void izintalep_Load(object sender, EventArgs e)
        {
            vericek();
        }
        private void vericek()
        {
            
            stoklabel.Text = stokislem.bilgigönder[0];
            urunlabel.Text = stokislem.bilgigönder[1];
            stokdurum.Text = stokislem.bilgigönder[3];
            

        }
        private void verigönder()
        {
            stokislem.bilgigönder[4] = stoktext.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stoktext.Text!="")
            {
            stokislem.gironay = true;
            verigönder();
            this.Close();
            }
        }
    }
}
