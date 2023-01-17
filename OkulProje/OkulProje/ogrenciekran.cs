using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class ogrenciekran : Form
    {
        public ogrenciekran()
        {
            InitializeComponent();
        }
        OkulDbEntities db = new OkulDbEntities();

        void listele()
        {
            
            dataGridView1.DataSource = db.tbl_ogrenciler.ToList();
           
            dataGridView1.Columns[6].Visible = false;
        }
        private void OgrenciPanel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            tbl_ogrenciler ekle = new tbl_ogrenciler();
            ekle.ogrenci_fullname = txtadsoyad.Text;
            ekle.ogrenci_no = txtogrenci_no.Text;
            ekle.ogrenci_birthdate = dateTimePicker1.Value;
            ekle.ogrenci_bolum = txtbolum.Text;
            ekle.ogrenci_recorddate = DateTime.Now;
            db.tbl_ogrenciler.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kaydı Oluşturuldu.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            
        }

       

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int OgrenciId = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var ogrencibul = db.tbl_ogrenciler.Find(OgrenciId);
                db.tbl_ogrenciler.Remove(ogrencibul);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Kayıdı Silindi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
         

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int OgrenciId = Convert.ToInt32(txtid.Text);

            var guncelle = db.tbl_ogrenciler.Find(OgrenciId);
            guncelle.ogrenci_fullname = txtadsoyad.Text;
            guncelle.ogrenci_no = txtogrenci_no.Text;
            guncelle.ogrenci_birthdate = dateTimePicker1.Value;
            guncelle.ogrenci_bolum = txtbolum.Text;
            guncelle.ogrenci_recorddate = DateTime.Now;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kayıdı Güncellendi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int OgrenciId = Convert.ToInt32(txtid.Text);

            var ogrencibul = db.tbl_ogrenciler.Find(OgrenciId);
            db.tbl_ogrenciler.Remove(ogrencibul);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kayıdı Silindi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtadsoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtogrenci_no.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtbolum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
