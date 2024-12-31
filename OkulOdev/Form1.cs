using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace OkulOdev
{
    public partial class Form1 : Form
    {
        Ogrenciler ogr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            try
            {
                using (var context = new OgrencilerDbContext())
                {
                    var ogr = new Ogrenciler()
                    {
                        Ad = Adtxt.Text,
                        Soyad = Soyadtxt.Text,
                        Numara = Numaratxt.Text
                    };
                    context.Ogrenci.Add(ogr);
                    context.SaveChanges();
                    MessageBox.Show("��renci Kaydedildi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata olu�tu..");


            }

        }

        private void Guncelletxt_Click(object sender, EventArgs e)
        {
            using (var ctx = new OgrencilerDbContext())
            {
                if (ogr != null)
                {
                    ogr.Numara = Numaratxt.Text.Trim();
                    ogr.Ad = Adtxt.Text.Trim();
                    ogr.Soyad = Soyadtxt.Text.Trim();
                    ctx.Entry(ogr).State = EntityState.Modified;
                    MessageBox.Show(ctx.SaveChanges() > 0 ? "G�ncelleme Ba�ar�l�" : "Ba�ar�s�z");
                }
                else
                {
                    MessageBox.Show("��renci Bulunamam��t�r..");
                }



            }
        }

        private void Bultxt_Click(object sender, EventArgs e)
        {
            using (var ctx = new OgrencilerDbContext())
            {
                var ogr = ctx.Ogrenci.Find(int.Parse(IDtxt.Text.Trim()));
                if (ogr != null)
                {
                    this.ogr = ogr;
                    Adtxt.Text = ogr.Ad;
                    Soyadtxt.Text = ogr.Soyad;
                    Numaratxt.Text = ogr.Numara;
                }
                else
                {
                    MessageBox.Show("��renci bulunamad�");
                }

            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}