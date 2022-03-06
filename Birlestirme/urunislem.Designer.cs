namespace Birlestirme
{
    partial class urunislem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunislem));
            this.listeurun = new System.Windows.Forms.DataGridView();
            this.Kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyatc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.silbutton = new System.Windows.Forms.Button();
            this.temmizle = new System.Windows.Forms.Button();
            this.duzenlebutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ek = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boyut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.agirlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.turbilgi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stokkodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stokbilgi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arama = new System.Windows.Forms.TextBox();
            this.urunad = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yenile = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.listeurun)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenile)).BeginInit();
            this.SuspendLayout();
            // 
            // listeurun
            // 
            this.listeurun.AllowUserToAddRows = false;
            this.listeurun.AllowUserToDeleteRows = false;
            this.listeurun.AllowUserToOrderColumns = true;
            this.listeurun.AllowUserToResizeColumns = false;
            this.listeurun.AllowUserToResizeRows = false;
            this.listeurun.BackgroundColor = System.Drawing.Color.White;
            this.listeurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeurun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kodu,
            this.Urun,
            this.Fiyatc,
            this.Column1,
            this.Column5,
            this.Column3,
            this.Column2,
            this.Column4});
            this.listeurun.Location = new System.Drawing.Point(267, 12);
            this.listeurun.MultiSelect = false;
            this.listeurun.Name = "listeurun";
            this.listeurun.ReadOnly = true;
            this.listeurun.RowHeadersVisible = false;
            this.listeurun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeurun.Size = new System.Drawing.Size(929, 397);
            this.listeurun.TabIndex = 59;
            this.listeurun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeurun_CellContentClick);
            this.listeurun.Click += new System.EventHandler(this.listeurun_Click);
            // 
            // Kodu
            // 
            this.Kodu.HeaderText = "Kodu";
            this.Kodu.Name = "Kodu";
            this.Kodu.ReadOnly = true;
            this.Kodu.Width = 80;
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Ürün Adı";
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            this.Urun.Width = 240;
            // 
            // Fiyatc
            // 
            this.Fiyatc.HeaderText = "Fiyat";
            this.Fiyatc.Name = "Fiyatc";
            this.Fiyatc.ReadOnly = true;
            this.Fiyatc.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kalan";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tür";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Boyut";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ağırlık";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ek";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "     ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Stoktaki Çeşit:";
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.DarkRed;
            this.silbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("silbutton.BackgroundImage")));
            this.silbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.silbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silbutton.Enabled = false;
            this.silbutton.Location = new System.Drawing.Point(1208, 69);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(82, 37);
            this.silbutton.TabIndex = 55;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // temmizle
            // 
            this.temmizle.BackColor = System.Drawing.Color.Snow;
            this.temmizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temmizle.Enabled = false;
            this.temmizle.Location = new System.Drawing.Point(284, 100);
            this.temmizle.Name = "temmizle";
            this.temmizle.Size = new System.Drawing.Size(75, 32);
            this.temmizle.TabIndex = 53;
            this.temmizle.Text = "Vazgeç";
            this.temmizle.UseVisualStyleBackColor = false;
            this.temmizle.Click += new System.EventHandler(this.temmizle_Click);
            // 
            // duzenlebutton
            // 
            this.duzenlebutton.BackColor = System.Drawing.Color.Peru;
            this.duzenlebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duzenlebutton.Enabled = false;
            this.duzenlebutton.Location = new System.Drawing.Point(191, 100);
            this.duzenlebutton.Name = "duzenlebutton";
            this.duzenlebutton.Size = new System.Drawing.Size(75, 32);
            this.duzenlebutton.TabIndex = 52;
            this.duzenlebutton.Text = "Kaydet";
            this.duzenlebutton.UseVisualStyleBackColor = false;
            this.duzenlebutton.Click += new System.EventHandler(this.duzenlebutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Ek:";
            // 
            // ek
            // 
            this.ek.Location = new System.Drawing.Point(568, 47);
            this.ek.Name = "ek";
            this.ek.Size = new System.Drawing.Size(100, 20);
            this.ek.TabIndex = 49;
            this.ek.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Fiyat :";
            // 
            // fiyat
            // 
            this.fiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fiyat.Location = new System.Drawing.Point(568, 18);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(100, 20);
            this.fiyat.TabIndex = 47;
            this.fiyat.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Urdu Typesetting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(20)));
            this.label7.Location = new System.Drawing.Point(71, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Stok Kodu */ Ürün Adı*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Boyut";
            // 
            // boyut
            // 
            this.boyut.Location = new System.Drawing.Point(410, 47);
            this.boyut.Name = "boyut";
            this.boyut.Size = new System.Drawing.Size(100, 20);
            this.boyut.TabIndex = 44;
            this.boyut.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ağırlık";
            // 
            // agirlik
            // 
            this.agirlik.Location = new System.Drawing.Point(410, 18);
            this.agirlik.Name = "agirlik";
            this.agirlik.Size = new System.Drawing.Size(100, 20);
            this.agirlik.TabIndex = 42;
            this.agirlik.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tür:";
            // 
            // turbilgi
            // 
            this.turbilgi.Location = new System.Drawing.Point(243, 44);
            this.turbilgi.Name = "turbilgi";
            this.turbilgi.Size = new System.Drawing.Size(100, 20);
            this.turbilgi.TabIndex = 40;
            this.turbilgi.Text = "5";
            this.turbilgi.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Stokkodu";
            // 
            // stokkodu
            // 
            this.stokkodu.Enabled = false;
            this.stokkodu.Location = new System.Drawing.Point(68, 21);
            this.stokkodu.Name = "stokkodu";
            this.stokkodu.Size = new System.Drawing.Size(100, 20);
            this.stokkodu.TabIndex = 38;
            this.stokkodu.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Stok Bilgisi:";
            // 
            // stokbilgi
            // 
            this.stokbilgi.Location = new System.Drawing.Point(68, 44);
            this.stokbilgi.Name = "stokbilgi";
            this.stokbilgi.Size = new System.Drawing.Size(100, 20);
            this.stokbilgi.TabIndex = 36;
            this.stokbilgi.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ürün Adı :";
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(87, 55);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(100, 20);
            this.arama.TabIndex = 33;
            this.arama.TextChanged += new System.EventHandler(this.arama_TextChanged);
            this.arama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arama_KeyPress);
            // 
            // urunad
            // 
            this.urunad.Location = new System.Drawing.Point(243, 14);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(100, 20);
            this.urunad.TabIndex = 34;
            this.urunad.TextChanged += new System.EventHandler(this.stokkodu_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Gothic", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(40, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 27);
            this.label12.TabIndex = 61;
            this.label12.Text = "Yetki : Admin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Gothic", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(22, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 32);
            this.label14.TabIndex = 62;
            this.label14.Text = "Yetkili: BY Admin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.temmizle);
            this.panel1.Controls.Add(this.duzenlebutton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ek);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.fiyat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.boyut);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.agirlik);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.turbilgi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stokkodu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stokbilgi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.urunad);
            this.panel1.Location = new System.Drawing.Point(337, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 149);
            this.panel1.TabIndex = 65;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.BackgroundImage = global::Birlestirme.Properties.Resources.button1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1208, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 66;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1208, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 42);
            this.button2.TabIndex = 67;
            this.button2.Text = "Yeni Ürün Gir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Birlestirme.Properties.Resources.button1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1208, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 42);
            this.button3.TabIndex = 68;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Birlestirme.Properties.Resources.yukleniyorgif;
            this.pictureBox1.Location = new System.Drawing.Point(104, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.Transparent;
            this.yenile.Location = new System.Drawing.Point(170, 209);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(43, 29);
            this.yenile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yenile.TabIndex = 54;
            this.yenile.TabStop = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // urunislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 728);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listeurun);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arama);
            this.DoubleBuffered = true;
            this.Name = "urunislem";
            this.Opacity = 0.2D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeurun)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeurun;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.PictureBox yenile;
        private System.Windows.Forms.Button temmizle;
        private System.Windows.Forms.Button duzenlebutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boyut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox agirlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox turbilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stokkodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stokbilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.TextBox urunad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyatc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}