namespace OkulOdev
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
            Soyadtxt = new TextBox();
            Numaratxt = new TextBox();
            groupBox1 = new GroupBox();
            IDtxt = new TextBox();
            IDlabel = new Label();
            btnKaydet = new Button();
            Bultxt = new Button();
            Guncelletxt = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Adlabel
            // 
            Adlabel.AutoSize = true;
            Adlabel.Location = new Point(76, 110);
            Adlabel.Name = "Adlabel";
            Adlabel.Size = new Size(28, 20);
            Adlabel.TabIndex = 0;
            Adlabel.Text = "Ad";
            // 
            // Soyadlabel
            // 
            Soyadlabel.AutoSize = true;
            Soyadlabel.Location = new Point(76, 150);
            Soyadlabel.Name = "Soyadlabel";
            Soyadlabel.Size = new Size(50, 20);
            Soyadlabel.TabIndex = 1;
            Soyadlabel.Text = "Soyad";
            // 
            // Numaralabel
            // 
            Numaralabel.AutoSize = true;
            Numaralabel.Location = new Point(76, 196);
            Numaralabel.Name = "Numaralabel";
            Numaralabel.Size = new Size(62, 20);
            Numaralabel.TabIndex = 2;
            Numaralabel.Text = "Numara";
            // 
            // Adtxt
            // 
            Adtxt.Location = new Point(173, 107);
            Adtxt.Name = "Adtxt";
            Adtxt.Size = new Size(125, 27);
            Adtxt.TabIndex = 3;
            // 
            // Soyadtxt
            // 
            Soyadtxt.Location = new Point(173, 147);
            Soyadtxt.Name = "Soyadtxt";
            Soyadtxt.Size = new Size(125, 27);
            Soyadtxt.TabIndex = 4;
            // 
            // Numaratxt
            // 
            Numaratxt.Location = new Point(173, 193);
            Numaratxt.Name = "Numaratxt";
            Numaratxt.Size = new Size(125, 27);
            Numaratxt.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IDtxt);
            groupBox1.Controls.Add(IDlabel);
            groupBox1.Controls.Add(Adtxt);
            groupBox1.Controls.Add(Numaratxt);
            groupBox1.Controls.Add(Adlabel);
            groupBox1.Controls.Add(Numaralabel);
            groupBox1.Controls.Add(Soyadtxt);
            groupBox1.Controls.Add(Soyadlabel);
            groupBox1.Location = new Point(196, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 244);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ogrenci Ekleme";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // IDtxt
            // 
            IDtxt.Location = new Point(173, 60);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(125, 27);
            IDtxt.TabIndex = 7;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(76, 67);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(24, 20);
            IDlabel.TabIndex = 6;
            IDlabel.Text = "ID";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(295, 301);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(166, 34);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Bultxt
            // 
            Bultxt.Location = new Point(510, 302);
            Bultxt.Name = "Bultxt";
            Bultxt.Size = new Size(162, 34);
            Bultxt.TabIndex = 8;
            Bultxt.Text = "Bul";
            Bultxt.UseVisualStyleBackColor = true;
            Bultxt.Click += Bultxt_Click;
            // 
            // Guncelletxt
            // 
            Guncelletxt.Location = new Point(90, 302);
            Guncelletxt.Name = "Guncelletxt";
            Guncelletxt.Size = new Size(162, 33);
            Guncelletxt.TabIndex = 9;
            Guncelletxt.Text = "Güncelle";
            Guncelletxt.UseVisualStyleBackColor = true;
            Guncelletxt.Click += Guncelletxt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Guncelletxt);
            Controls.Add(Bultxt);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Adlabel;
        private Label Soyadlabel;
        private Label Numaralabel;
        private TextBox Adtxt;
        private TextBox Soyadtxt;
        private TextBox Numaratxt;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private TextBox IDtxt;
        private Label IDlabel;
        private Button Bultxt;
        private Button Guncelletxt;
    }
}