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
    public partial class dersekranlistele : Form
    {
        public dersekranlistele()
        {
            InitializeComponent();
        }

        OkulDbEntities db = new OkulDbEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.tbl_ders
                                        select new
                                        {
                                            x.ders_id,
                                            x.ders_ad,
                                            x.ders_kredi,
                                            x.tbl_okulyonetim.yonetim_adsoyad

                                        }).ToList();



            //dataGridView1.Columns[4].Visible = false;

            var derslist = db.tbl_ders.ToList();


        }

        private void dersekranlistele_Load(object sender, EventArgs e)
        {
            listele();
            var ogretmenler = (from x in db.tbl_okulyonetim
                               where x.yonetim_tip == "12"
                               select new
                               {
                                   x.yonetim_id,
                                   x.yonetim_adsoyad

                               }).ToList();
            /*
            comboBox1.ValueMember = "yonetim_id";
            comboBox1.DisplayMember = "yonetim_adsoyad";
            comboBox1.DataSource = ogretmenler;
            */
        }
    }
}
