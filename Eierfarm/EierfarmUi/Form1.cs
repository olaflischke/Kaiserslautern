using EierfarmBl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EierfarmUi
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

        private void btnNeuesHuhn_Click(object sender, EventArgs e)
        {
            Huhn huhn = new Huhn("Neues Huhn");

            cbxTiere.Items.Add(huhn);
            cbxTiere.SelectedItem = huhn;
        }

        private void btnNeueGans_Click(object sender, EventArgs e)
        {
            Gans gans = new Gans("Neue Gans");

            cbxTiere.Items.Add(gans);
            cbxTiere.SelectedItem = gans;
        }

        private void cbxTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgdTier.SelectedObject = cbxTiere.SelectedItem;
        }

        private void btnFuettern_Click(object sender, EventArgs e)
        {
            IGefluegel huhn = cbxTiere.SelectedItem as IGefluegel; // SafeCast: Liefert null, wenn Cast fehlschlägt
            if (huhn != null)
            {
                huhn.Fressen();
                pgdTier.SelectedObject = huhn;
            }

        }

        private void btnEiLegen_Click(object sender, EventArgs e)
        {
            IGefluegel huhn = cbxTiere.SelectedItem as IGefluegel;
            huhn?.EiLegen();
            pgdTier.SelectedObject = huhn;
        }

        private void btnNeuesSchnabeltier_Click(object sender, EventArgs e)
        {
            Schnabeltier schnabeltier = new Schnabeltier() { Name = "Neues Schnabeltier" };

            cbxTiere.Items.Add(schnabeltier);
            cbxTiere.SelectedItem = schnabeltier;
        }
    }
}
