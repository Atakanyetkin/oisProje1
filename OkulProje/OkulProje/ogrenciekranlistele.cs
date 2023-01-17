using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class ogrenciekranlistele : Form
    {
        public ogrenciekranlistele()
        {
            InitializeComponent();
        }
        OkulDbEntities db = new OkulDbEntities();

        void listele()
        {

            dataGridView1.DataSource = db.tbl_ogrenciler.ToList();

            dataGridView1.Columns[6].Visible = false;
        }

        private void ogrenciekranlistele_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ad Soyad")
            {
                var sonuc = from rec in db.tbl_ogrenciler where rec.ogrenci_fullname.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Öğrenci No")
            {
                var sonuc = from rec in db.tbl_ogrenciler where rec.ogrenci_no.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Bolum")
            {
                var sonuc = from rec in db.tbl_ogrenciler where rec.ogrenci_bolum.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
