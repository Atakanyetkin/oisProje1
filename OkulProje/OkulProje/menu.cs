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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciekran ogrpanel = new ogrenciekran();
            ogrpanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okulyönetimekran oklyonetim = new okulyönetimekran();
            oklyonetim.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersekran derspanel = new dersekran();
            derspanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrencidersekran derspanel = new ogrencidersekran();
            derspanel.Show();
        }

        private void listgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersekranlistele dersekranlistele = new dersekranlistele();
            dersekranlistele.Show();
        }

        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okulyönetimekran oklyonetim = new okulyönetimekran();
            oklyonetim.Show();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersekran derspanel = new dersekran();
            derspanel.Show();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ogrenciekranlistele ogrenciekranlistele = new ogrenciekranlistele();
            ogrenciekranlistele.Show();
        }

        private void girisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ogrenciekran ogrpanel = new ogrenciekran();
            ogrpanel.Show();
        }

        private void girisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ogrencidersekran derspanel = new ogrencidersekran();
            derspanel.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okulyönetimiekranlistele okulyönetimiekranlistele = new okulyönetimiekranlistele();
            okulyönetimiekranlistele.Show();
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ogrencidersekranlistele ogrencidersekranlistele = new ogrencidersekranlistele();
            ogrencidersekranlistele.Show();
        }
    }
}
