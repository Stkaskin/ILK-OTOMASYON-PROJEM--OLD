namespace Birlestirme
{
    partial class personelduzenle
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.perkod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Personel No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "İsim:";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(327, 151);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 20);
            this.isim.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Vazgeç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cinsiyet
            // 
            this.cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet.Location = new System.Drawing.Point(327, 177);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cinsiyet.TabIndex = 61;
            // 
            // perkod
            // 
            this.perkod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.perkod.Location = new System.Drawing.Point(328, 123);
            this.perkod.Name = "perkod";
            this.perkod.Size = new System.Drawing.Size(100, 23);
            this.perkod.TabIndex = 62;
            // 
            // personelduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(763, 467);
            this.Controls.Add(this.perkod);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isim);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "personelduzenle";
            this.Text = "personelduzenle";
            this.Load += new System.EventHandler(this.personelduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cinsiyet;
        private System.Windows.Forms.Label perkod;
    }
}