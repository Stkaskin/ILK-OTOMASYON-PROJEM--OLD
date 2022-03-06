namespace Birlestirme
{
    partial class satisislem
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.filtrebutton = new System.Windows.Forms.Button();
            this.filtrepanel = new System.Windows.Forms.Panel();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.turcombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.label9 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyatc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.aramayap = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listeurun = new System.Windows.Forms.ListView();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.filtrepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Temizle /İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Çıkar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tutar :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tür1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(217, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yükleniyor";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 58);
            this.progressBar1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 452);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Tag = "";
            // 
            // filtrebutton
            // 
            this.filtrebutton.Location = new System.Drawing.Point(301, 3);
            this.filtrebutton.Name = "filtrebutton";
            this.filtrebutton.Size = new System.Drawing.Size(91, 23);
            this.filtrebutton.TabIndex = 11;
            this.filtrebutton.Text = "Filtrele";
            this.filtrebutton.UseVisualStyleBackColor = true;
            this.filtrebutton.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // filtrepanel
            // 
            this.filtrepanel.Controls.Add(this.textBox2);
            this.filtrepanel.Controls.Add(this.textBox1);
            this.filtrepanel.Controls.Add(this.button9);
            this.filtrepanel.Controls.Add(this.markacombo);
            this.filtrepanel.Controls.Add(this.turcombo);
            this.filtrepanel.Controls.Add(this.button5);
            this.filtrepanel.Controls.Add(this.button3);
            this.filtrepanel.Controls.Add(this.label5);
            this.filtrepanel.Controls.Add(this.label6);
            this.filtrepanel.Controls.Add(this.label4);
            this.filtrepanel.Controls.Add(this.label10);
            this.filtrepanel.Controls.Add(this.label8);
            this.filtrepanel.Controls.Add(this.label7);
            this.filtrepanel.Controls.Add(this.hScrollBar2);
            this.filtrepanel.Controls.Add(this.label9);
            this.filtrepanel.Controls.Add(this.hScrollBar1);
            this.filtrepanel.Location = new System.Drawing.Point(1075, 48);
            this.filtrepanel.Name = "filtrepanel";
            this.filtrepanel.Size = new System.Drawing.Size(271, 344);
            this.filtrepanel.TabIndex = 12;
            this.filtrepanel.Visible = false;
            this.filtrepanel.VisibleChanged += new System.EventHandler(this.filtrepanel_VisibleChanged);
            // 
            // markacombo
            // 
            this.markacombo.DisplayMember = "1";
            this.markacombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Location = new System.Drawing.Point(113, 59);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(121, 21);
            this.markacombo.TabIndex = 21;
            // 
            // turcombo
            // 
            this.turcombo.DisplayMember = "1";
            this.turcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turcombo.FormattingEnabled = true;
            this.turcombo.Location = new System.Drawing.Point(114, 26);
            this.turcombo.Name = "turcombo";
            this.turcombo.Size = new System.Drawing.Size(121, 21);
            this.turcombo.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(154, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 42);
            this.button5.TabIndex = 19;
            this.button5.Text = "Vazgeç";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 18;
            this.button3.Text = "Onayla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "En Düşük Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tür";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(176, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(140, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "En Yüksek Fiyat";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar2.Location = new System.Drawing.Point(110, 158);
            this.hScrollBar2.Maximum = 1009;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(120, 15);
            this.hScrollBar2.TabIndex = 15;
            this.hScrollBar2.Value = 1009;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(195, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "1000";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar1.Location = new System.Drawing.Point(110, 130);
            this.hScrollBar1.Maximum = 1008;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(120, 15);
            this.hScrollBar1.TabIndex = 13;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(398, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Filtreyi Temizle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(995, 437);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 42);
            this.button7.TabIndex = 14;
            this.button7.Text = "<>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.aramayap);
            this.panel1.Location = new System.Drawing.Point(401, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 384);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kodu,
            this.Urun,
            this.Column5,
            this.Column1,
            this.Fiyatc});
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 511);
            this.dataGridView1.TabIndex = 60;
            // 
            // Kodu
            // 
            this.Kodu.HeaderText = "Kodu";
            this.Kodu.Name = "Kodu";
            this.Kodu.ReadOnly = true;
            this.Kodu.Width = 70;
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Ürün Adı";
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            this.Urun.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tür";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marka";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Fiyatc
            // 
            this.Fiyatc.HeaderText = "Fiyat";
            this.Fiyatc.Name = "Fiyatc";
            this.Fiyatc.ReadOnly = true;
            this.Fiyatc.Width = 80;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(536, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 65);
            this.button8.TabIndex = 16;
            this.button8.Text = "Sat";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Stok Kodu & Ürün Adı";
            // 
            // aramayap
            // 
            this.aramayap.Location = new System.Drawing.Point(297, 7);
            this.aramayap.Name = "aramayap";
            this.aramayap.Size = new System.Drawing.Size(100, 20);
            this.aramayap.TabIndex = 0;
            this.aramayap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.filtrebutton);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(473, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 484);
            this.panel2.TabIndex = 16;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tutar";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "---";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "---";
            // 
            // listeurun
            // 
            this.listeurun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listeurun.FullRowSelect = true;
            this.listeurun.Location = new System.Drawing.Point(9, 38);
            this.listeurun.Name = "listeurun";
            this.listeurun.Size = new System.Drawing.Size(386, 338);
            this.listeurun.TabIndex = 7;
            this.listeurun.UseCompatibleStateImageBehavior = false;
            this.listeurun.View = System.Windows.Forms.View.Details;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(237, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 19);
            this.button9.TabIndex = 22;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.VisibleChanged += new System.EventHandler(this.textBox2_VisibleChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox2.VisibleChanged += new System.EventHandler(this.textBox2_VisibleChanged);
            // 
            // satisislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.filtrepanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeurun);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "satisislem";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.filtrepanel.ResumeLayout(false);
            this.filtrepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button filtrebutton;
        private System.Windows.Forms.Panel filtrepanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.ComboBox turcombo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox aramayap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyatc;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listeurun;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}