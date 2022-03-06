namespace Birlestirme
{
    partial class stokislem
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
            this.listeurun = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listeurun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.Column3,
            this.stok});
            this.listeurun.Location = new System.Drawing.Point(15, 71);
            this.listeurun.MultiSelect = false;
            this.listeurun.Name = "listeurun";
            this.listeurun.ReadOnly = true;
            this.listeurun.RowHeadersVisible = false;
            this.listeurun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeurun.Size = new System.Drawing.Size(405, 392);
            this.listeurun.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 61;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.kalan});
            this.dataGridView2.Location = new System.Drawing.Point(568, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(412, 451);
            this.dataGridView2.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "No:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Urun Adi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Girdi-Cikti";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "S.D.T";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // kalan
            // 
            this.kalan.HeaderText = "kalan";
            this.kalan.Name = "kalan";
            this.kalan.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1078, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 47);
            this.button1.TabIndex = 63;
            this.button1.Text = "Günlük Log";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1078, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 47);
            this.button2.TabIndex = 64;
            this.button2.Text = "Aylık Log";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1078, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 47);
            this.button3.TabIndex = 65;
            this.button3.Text = "Yıllık Log";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(490, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 39);
            this.button7.TabIndex = 69;
            this.button7.Text = "Stoğa Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1078, 204);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 47);
            this.button16.TabIndex = 78;
            this.button16.Text = "Gelecek Ürünler";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(1078, 257);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 47);
            this.button19.TabIndex = 80;
            this.button19.Text = "Arz / Talep / İstatislik";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1078, 324);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 47);
            this.button18.TabIndex = 81;
            this.button18.Text = "Azalan ";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Ürün *Kodu/*İsmi";
            // 
            // Kodu
            // 
            this.Kodu.HeaderText = "Stok Kodu";
            this.Kodu.Name = "Kodu";
            this.Kodu.ReadOnly = true;
            this.Kodu.Width = 80;
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Ürün İsm";
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            this.Urun.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marka";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // stok
            // 
            this.stok.HeaderText = "Stok";
            this.stok.Name = "stok";
            this.stok.ReadOnly = true;
            // 
            // stokislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1297, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listeurun);
            this.Name = "stokislem";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeurun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeurun;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
    }
}