using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulProje
{
    public partial class ogrencidersekran : Form
    {
        public ogrencidersekran()
        {
            InitializeComponent();
        }

        OkulDbEntities db = new OkulDbEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.tbl_ogrenciders
                                        select new
                                        {
                                            x.ogrenciders_dersid,
                                            x.tbl_ders.ders_ad,
                                            x.tbl_ogrenciler.ogrenci_fullname
                                           
                                           

                                        }).ToList();
           
          


    

            var derslist = db.tbl_ders.ToList();


        }

        private void OgrenciDersPanel_Load(object sender, EventArgs e)
        {
            listele();
            var ogrenciler = (from x in db.tbl_ogrenciler
                               select new
                               {
                                   x.ogrenci_id,
                                   x.ogrenci_fullname

                               }).ToList();

            cmbogrenci.ValueMember = "ogrenciid";
            cmbogrenci.DisplayMember = "ogrenci_fullname";
            cmbogrenci.DataSource = ogrenciler; listele();


            var dersler = (from x in db.tbl_ders
                              select new
                              {
                                  x.ders_id,
                                  x.ders_ad

                              }).ToList();

            cmbders.ValueMember = "ders_id";
            cmbders.DisplayMember = "ders_ad";
            cmbders.DataSource = dersler; listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbders.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbogrenci.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
          
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int ogrenciders_dersid = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var ogrencidersbul = db.tbl_ogrenciders.Find(ogrenciders_dersid);
                db.tbl_ogrenciders.Remove(ogrencidersbul);
                db.SaveChanges();
                MessageBox.Show("Ders Ve Öğrenci İlişkisi Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_ogrenciders ekle = new tbl_ogrenciders();
            ekle.ogrenciders_dersid = Convert.ToInt16(cmbders.SelectedValue);
            ekle.ogrenciders_ogrenciid = Convert.ToInt16(cmbogrenci.SelectedValue);
            db.tbl_ogrenciders.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenciye Ders Ataması Yapıldı.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

       

        

        private void button3_Click(object sender, EventArgs e)
        {
            
                listele();
            
        }
    }
}
