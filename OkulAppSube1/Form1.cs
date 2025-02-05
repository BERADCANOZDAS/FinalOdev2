﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*if (txtAd.Text==String.Empty|| txtSoyad.Text==String.Empty || txtNumara.Text==String.Empty)
            {
                MessageBox.Show("Tüm alanlar zorunludur");
                return;
            }
            */
            bool kontrol = false;
            foreach (Control item in grpOgrenci.Controls)
            {
                if (item is TextBox && item.Text==string.Empty)
                {
                    item.BackColor = Color.Red;
                    kontrol = true;
                }

            }
            if (kontrol) { MessageBox.Show("Tüm Alanlar zorunludur");
                return;
            }
            
            SqlConnection cn = null;
            SqlCommand cmd = null;
            try
            {   //using direkt dispose yapar.
                using (cn = new SqlConnection("Data Source = localhost; Initial Catalog = OkulDbSube1; Integrated Security=true"))
                {
                    using (cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad , @Soyad , @Numara)", cn)) 
                    {
                        SqlParameter[] p = { 
                        new SqlParameter("@Ad",txtAd.Text.Trim()),
                        new SqlParameter("@Soyad",txtSoyad.Text.Trim()),
                        new SqlParameter("@Numara",txtNumara.Text.Trim())
                        };
                        cmd.Parameters.AddRange(p);

                        if (cn != null && cn.State != ConnectionState.Open)
                        {
                            cn.Open();
                        }
                        int sonuc = cmd.ExecuteNonQuery();
                        MessageBox.Show(sonuc > 0 ? "Ekleme Başarılı" : "Ekleme Başarısız");
                    }
                    
                }
                 
                 
            }
            catch (Exception)
            {
                
                MessageBox.Show("Bir hata oluştu...");
                
            }

           /* finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                    cn.Dispose();
                    cmd.Dispose();
                }
            }*/

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
            if (txt.Text == string.Empty)
            {
                txt.BackColor= Color.Red;
            }
        }
    }
}
