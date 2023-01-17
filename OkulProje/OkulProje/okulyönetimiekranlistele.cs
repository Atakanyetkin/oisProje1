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
    public partial class okulyönetimiekranlistele : Form
    {
        public okulyönetimiekranlistele()
        {
            InitializeComponent();
        }
        OkulDbEntities db = new OkulDbEntities();
        public string deger;

        void listele()
        {
            dataGridView1.DataSource = db.tbl_okulyonetim.ToList();
            dataGridView1.Columns[4].Visible = false;

            var list = db.tbl_okulyonetim.ToList();


        }

        private void okulyönetimiekranlistele_Load(object sender, EventArgs e)
        {
            listele();
            /*
            cmbpozisyon.Items.Add("İdare");
            cmbpozisyon.Items.Add("Öğretmen");
            cmbpozisyon.Items.Add("Öğrenci İşleri");
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Görevli Adı")
            {
                var sonuc = from rec in db.tbl_okulyonetim where rec.yonetim_adsoyad.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Görevi")
            {
                var sonuc = from rec in db.tbl_okulyonetim where rec.yonetim_gorev.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
