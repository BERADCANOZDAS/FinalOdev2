namespace FinalOdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Adlabel = new Label();
            Soyadlabel = new Label();
            Numaralabel = new Label();
            Adtxt = new TextBox();
            Numaratxt = new TextBox();
            Soyadtxt = new TextBox();
            grpOgrenci = new GroupBox();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            btnBul = new Button();
            btnDersSecimi = new Button();
            grpOgrenci.SuspendLayout();
            SuspendLayout();
            // 
            // Adlabel
            // 
            Adlabel.AutoSize = true;
            Adlabel.Location = new Point(35, 40);
            Adlabel.Name = "Adlabel";
            Adlabel.Size = new Size(28, 20);
            Adlabel.TabIndex = 0;
            Adlabel.Text = "Ad";
            // 
            // Soyadlabel
            // 
            Soyadlabel.AutoSize = true;
            Soyadlabel.Location = new Point(35, 82);
            Soyadlabel.Name = "Soyadlabel";
            Soyadlabel.Size = new Size(50, 20);
            Soyadlabel.TabIndex = 1;
            Soyadlabel.Text = "Soyad";
            // 
            // Numaralabel
            // 
            Numaralabel.AutoSize = true;
            Numaralabel.Location = new Point(35, 125);
            Numaralabel.Name = "Numaralabel";
            Numaralabel.Size = new Size(62, 20);
            Numaralabel.TabIndex = 2;
            Numaralabel.Text = "Numara";
            // 
            // Adtxt
            // 
            Adtxt.Location = new Point(143, 40);
            Adtxt.Name = "Adtxt";
            Adtxt.Size = new Size(125, 27);
            Adtxt.TabIndex = 3;
            // 
            // Numaratxt
            // 
            Numaratxt.Location = new Point(143, 125);
            Numaratxt.Name = "Numaratxt";
            Numaratxt.Size = new Size(125, 27);
            Numaratxt.TabIndex = 4;
            // 
            // Soyadtxt
            // 
            Soyadtxt.Location = new Point(143, 82);
            Soyadtxt.Name = "Soyadtxt";
            Soyadtxt.Size = new Size(125, 27);
            Soyadtxt.TabIndex = 5;
            // 
            // grpOgrenci
            // 
            grpOgrenci.Controls.Add(Numaratxt);
            grpOgrenci.Controls.Add(Soyadtxt);
            grpOgrenci.Controls.Add(Adlabel);
            grpOgrenci.Controls.Add(Soyadlabel);
            grpOgrenci.Controls.Add(Adtxt);
            grpOgrenci.Controls.Add(Numaralabel);
            grpOgrenci.Location = new Point(221, 42);
            grpOgrenci.Name = "grpOgrenci";
            grpOgrenci.Size = new Size(302, 225);
            grpOgrenci.TabIndex = 6;
            grpOgrenci.TabStop = false;
            grpOgrenci.Text = "Öğrenci";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(157, 286);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(108, 38);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(302, 286);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(108, 38);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(452, 286);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(108, 38);
            btnBul.TabIndex = 9;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.Location = new Point(256, 364);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(194, 38);
            btnDersSecimi.TabIndex = 10;
            btnDersSecimi.Text = "Ders Seçimi";
            btnDersSecimi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDersSecimi);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(grpOgrenci);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpOgrenci.ResumeLayout(false);
            grpOgrenci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Adlabel;
        private Label Soyadlabel;
        private Label Numaralabel;
        private TextBox Adtxt;
        private TextBox Numaratxt;
        private TextBox Soyadtxt;
        private GroupBox grpOgrenci;
        private Button btnGuncelle;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnDersSecimi;
    }
}