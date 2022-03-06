namespace Birlestirme
{
    partial class perislem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perislem));
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personellistesi = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.silbutton = new System.Windows.Forms.Button();
            this.temmizle = new System.Windows.Forms.Button();
            this.duzenlebutton = new System.Windows.Forms.Button();
            this.eklebutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.isimlabel = new System.Windows.Forms.Label();
            this.numaralabel = new System.Windows.Forms.Label();
            this.vesikalik = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.personellistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesikalik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Urun
            // 
            this.Urun.HeaderText = "İsim";
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            this.Urun.Width = 240;
            // 
            // Kodu
            // 
            this.Kodu.HeaderText = "P.No";
            this.Kodu.Name = "Kodu";
            this.Kodu.ReadOnly = true;
            this.Kodu.Width = 80;
            // 
            // personellistesi
            // 
            this.personellistesi.AllowUserToAddRows = false;
            this.personellistesi.AllowUserToDeleteRows = false;
            this.personellistesi.AllowUserToOrderColumns = true;
            this.personellistesi.AllowUserToResizeColumns = false;
            this.personellistesi.AllowUserToResizeRows = false;
            this.personellistesi.BackgroundColor = System.Drawing.Color.White;
            this.personellistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personellistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kodu,
            this.Urun});
            this.personellistesi.Location = new System.Drawing.Point(23, 45);
            this.personellistesi.MultiSelect = false;
            this.personellistesi.Name = "personellistesi";
            this.personellistesi.ReadOnly = true;
            this.personellistesi.RowHeadersVisible = false;
            this.personellistesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personellistesi.Size = new System.Drawing.Size(676, 334);
            this.personellistesi.TabIndex = 59;
            this.personellistesi.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "     ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Kayıtlı Çalışan Sayısı:";
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.DarkRed;
            this.silbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("silbutton.BackgroundImage")));
            this.silbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.silbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silbutton.Enabled = false;
            this.silbutton.Location = new System.Drawing.Point(705, 146);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(75, 42);
            this.silbutton.TabIndex = 55;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // temmizle
            // 
            this.temmizle.BackColor = System.Drawing.Color.Snow;
            this.temmizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("temmizle.BackgroundImage")));
            this.temmizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.temmizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temmizle.Enabled = false;
            this.temmizle.Location = new System.Drawing.Point(705, 202);
            this.temmizle.Name = "temmizle";
            this.temmizle.Size = new System.Drawing.Size(75, 32);
            this.temmizle.TabIndex = 53;
            this.temmizle.Text = "Vazgeç";
            this.temmizle.UseVisualStyleBackColor = false;
            this.temmizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // duzenlebutton
            // 
            this.duzenlebutton.BackColor = System.Drawing.Color.Peru;
            this.duzenlebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("duzenlebutton.BackgroundImage")));
            this.duzenlebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.duzenlebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duzenlebutton.Enabled = false;
            this.duzenlebutton.Location = new System.Drawing.Point(705, 97);
            this.duzenlebutton.Name = "duzenlebutton";
            this.duzenlebutton.Size = new System.Drawing.Size(75, 39);
            this.duzenlebutton.TabIndex = 52;
            this.duzenlebutton.Text = "Düzenle";
            this.duzenlebutton.UseVisualStyleBackColor = false;
            this.duzenlebutton.Click += new System.EventHandler(this.duzenlebutton_Click);
            // 
            // eklebutton
            // 
            this.eklebutton.BackColor = System.Drawing.Color.LawnGreen;
            this.eklebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eklebutton.BackgroundImage")));
            this.eklebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eklebutton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.eklebutton.Location = new System.Drawing.Point(705, 45);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Size = new System.Drawing.Size(75, 39);
            this.eklebutton.TabIndex = 51;
            this.eklebutton.Text = "Yeni Kişi Ekle";
            this.eklebutton.UseVisualStyleBackColor = false;
            this.eklebutton.Click += new System.EventHandler(this.eklebutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Urdu Typesetting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(20)));
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Personel No/İsim";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(153, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // isimlabel
            // 
            this.isimlabel.AutoSize = true;
            this.isimlabel.Location = new System.Drawing.Point(896, 146);
            this.isimlabel.Name = "isimlabel";
            this.isimlabel.Size = new System.Drawing.Size(0, 13);
            this.isimlabel.TabIndex = 64;
            // 
            // numaralabel
            // 
            this.numaralabel.AutoSize = true;
            this.numaralabel.Location = new System.Drawing.Point(896, 175);
            this.numaralabel.Name = "numaralabel";
            this.numaralabel.Size = new System.Drawing.Size(0, 13);
            this.numaralabel.TabIndex = 64;
            // 
            // vesikalik
            // 
            this.vesikalik.BackColor = System.Drawing.Color.LightSkyBlue;
            this.vesikalik.Location = new System.Drawing.Point(880, 45);
            this.vesikalik.Name = "vesikalik";
            this.vesikalik.Size = new System.Drawing.Size(100, 87);
            this.vesikalik.TabIndex = 63;
            this.vesikalik.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(390, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // perislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1125, 523);
            this.Controls.Add(this.numaralabel);
            this.Controls.Add(this.isimlabel);
            this.Controls.Add(this.vesikalik);
            this.Controls.Add(this.personellistesi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.temmizle);
            this.Controls.Add(this.duzenlebutton);
            this.Controls.Add(this.eklebutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Name = "perislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PERSONEL İŞLEM";
            this.Load += new System.EventHandler(this.perislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personellistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vesikalik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu;
        private System.Windows.Forms.DataGridView personellistesi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button temmizle;
        private System.Windows.Forms.Button duzenlebutton;
        private System.Windows.Forms.Button eklebutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox vesikalik;
        private System.Windows.Forms.Label isimlabel;
        private System.Windows.Forms.Label numaralabel;
    }
}