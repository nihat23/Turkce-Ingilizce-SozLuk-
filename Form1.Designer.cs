namespace Sözlük_Yapımı
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1ekle = new System.Windows.Forms.Button();
            this.button2sil = new System.Windows.Forms.Button();
            this.button3guncelle = new System.Windows.Forms.Button();
            this.button4YaziDegis = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4hata = new System.Windows.Forms.Label();
            this.label4Toplam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingilizce :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(100, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(100, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(251, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 328);
            this.listBox1.TabIndex = 4;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button1ekle
            // 
            this.button1ekle.BackColor = System.Drawing.Color.Red;
            this.button1ekle.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1ekle.ForeColor = System.Drawing.Color.White;
            this.button1ekle.Location = new System.Drawing.Point(80, 122);
            this.button1ekle.Name = "button1ekle";
            this.button1ekle.Size = new System.Drawing.Size(165, 33);
            this.button1ekle.TabIndex = 5;
            this.button1ekle.Text = "Ekle";
            this.button1ekle.UseVisualStyleBackColor = false;
            this.button1ekle.Click += new System.EventHandler(this.button1ekle_Click);
            // 
            // button2sil
            // 
            this.button2sil.BackColor = System.Drawing.Color.ForestGreen;
            this.button2sil.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2sil.Location = new System.Drawing.Point(80, 178);
            this.button2sil.Name = "button2sil";
            this.button2sil.Size = new System.Drawing.Size(165, 28);
            this.button2sil.TabIndex = 6;
            this.button2sil.Text = "Sil ";
            this.button2sil.UseVisualStyleBackColor = false;
            this.button2sil.Click += new System.EventHandler(this.button2sil_Click);
            // 
            // button3guncelle
            // 
            this.button3guncelle.BackColor = System.Drawing.Color.Cyan;
            this.button3guncelle.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3guncelle.Location = new System.Drawing.Point(80, 229);
            this.button3guncelle.Name = "button3guncelle";
            this.button3guncelle.Size = new System.Drawing.Size(165, 28);
            this.button3guncelle.TabIndex = 7;
            this.button3guncelle.Text = "Güncelle";
            this.button3guncelle.UseVisualStyleBackColor = false;
            this.button3guncelle.Click += new System.EventHandler(this.button3guncelle_Click);
            // 
            // button4YaziDegis
            // 
            this.button4YaziDegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4YaziDegis.Location = new System.Drawing.Point(12, 320);
            this.button4YaziDegis.Name = "button4YaziDegis";
            this.button4YaziDegis.Size = new System.Drawing.Size(81, 27);
            this.button4YaziDegis.TabIndex = 10;
            this.button4YaziDegis.Text = "Yazı degiş";
            this.button4YaziDegis.UseVisualStyleBackColor = true;
            this.button4YaziDegis.Click += new System.EventHandler(this.button4YaziDegis_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(12, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nihatbeyi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(251, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bilgi :";
            // 
            // label4hata
            // 
            this.label4hata.AutoSize = true;
            this.label4hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4hata.ForeColor = System.Drawing.Color.Red;
            this.label4hata.Location = new System.Drawing.Point(298, 349);
            this.label4hata.Name = "label4hata";
            this.label4hata.Size = new System.Drawing.Size(23, 15);
            this.label4hata.TabIndex = 9;
            this.label4hata.Text = "__";
            // 
            // label4Toplam
            // 
            this.label4Toplam.AutoSize = true;
            this.label4Toplam.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4Toplam.ForeColor = System.Drawing.Color.Red;
            this.label4Toplam.Location = new System.Drawing.Point(368, -1);
            this.label4Toplam.Name = "label4Toplam";
            this.label4Toplam.Size = new System.Drawing.Size(16, 18);
            this.label4Toplam.TabIndex = 12;
            this.label4Toplam.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(247, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kelime Sayısı :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(703, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label4Toplam);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4YaziDegis);
            this.Controls.Add(this.label4hata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3guncelle);
            this.Controls.Add(this.button2sil);
            this.Controls.Add(this.button1ekle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "İngilizce türkçe sözlük";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1ekle;
        private System.Windows.Forms.Button button2sil;
        private System.Windows.Forms.Button button3guncelle;
        private System.Windows.Forms.Button button4YaziDegis;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4hata;
        private System.Windows.Forms.Label label4Toplam;
        private System.Windows.Forms.Label label4;
    }
}

