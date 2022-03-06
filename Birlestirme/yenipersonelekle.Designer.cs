namespace Birlestirme
{
    partial class yenipersonelekle
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
            this.isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.perkodlabel = new System.Windows.Forms.Label();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.GhostWhite;
            this.isim.Location = new System.Drawing.Point(175, 211);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 20);
            this.isim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İsim ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(526, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = " Personel Numarası :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // perkodlabel
            // 
            this.perkodlabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.perkodlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.perkodlabel.Location = new System.Drawing.Point(175, 182);
            this.perkodlabel.Name = "perkodlabel";
            this.perkodlabel.Size = new System.Drawing.Size(100, 22);
            this.perkodlabel.TabIndex = 8;
            this.perkodlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cinsiyet
            // 
            this.cinsiyet.BackColor = System.Drawing.Color.Gainsboro;
            this.cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet.Location = new System.Drawing.Point(175, 241);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cinsiyet.TabIndex = 62;
            // 
            // yenipersonelekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(664, 415);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.perkodlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yenipersonelekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yenipersonelekle";
            this.Load += new System.EventHandler(this.yenipersonelekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label perkodlabel;
        private System.Windows.Forms.ComboBox cinsiyet;
    }
}