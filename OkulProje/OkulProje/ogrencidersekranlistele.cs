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
    public partial class ogrencidersekranlistele : Form
    {
        public ogrencidersekranlistele()
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



        private void ogrencidersekranlistele_Load(object sender, EventArgs e)
        {
            listele();
            var ogrenciler = (from x in db.tbl_ogrenciler
                              select new
                              {
                                  x.ogrenci_id,
                                  x.ogrenci_fullname

                              }).ToList();
            

            var dersler = (from x in db.tbl_ders
                           select new
                           {
                               x.ders_id,
                               x.ders_ad

                           }).ToList();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ogrenci")
            {
                {
                    var arama = textBox1.Text;
                    var sonuc = (from x in db.tbl_ogrenciders
                                 where x.tbl_ogrenciler.ogrenci_fullname.Contains(arama)
                                 select new
                                 {
                                     x.ogrenciders_dersid,
                                     x.tbl_ders.ders_ad,
                                     x.tbl_ogrenciler.ogrenci_fullname

                                 }).ToList();
                    dataGridView1.DataSource = sonuc.ToList();


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
