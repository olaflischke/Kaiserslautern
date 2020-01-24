using EierfarmBl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

            huhn.EigenschaftGeaendert += Gefluegel_EigenschaftGeaendert;

            cbxTiere.Items.Add(huhn);
            cbxTiere.SelectedItem = huhn;
        }

        private void Gefluegel_EigenschaftGeaendert(object sender, GefluegelEventArgs e)
        {
            pgdTier.SelectedObject = (sender as IGefluegel);

            //MessageBox.Show($"Tier {(sender as Gefluegel).Name} hat Eigenschaft {e.GeaenderteEigenschaft} geändert.");
            //(sender as Gefluegel).EigenschaftGeaendert -= Gefluegel_EigenschaftGeaendert;
        }

        private void btnNeueGans_Click(object sender, EventArgs e)
        {
            Gans gans = new Gans("Neue Gans");

            gans.EigenschaftGeaendert += Gefluegel_EigenschaftGeaendert;
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

            // Umgang mit Nullables
            //int? a = null;
            //System.Nullable<int> b = null;

            //int c = (a.HasValue ? a.Value : -1);
            //int d = a ?? -1;

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

        // Speichern
        private void button2_Click(object sender, EventArgs e)
        {
            IGefluegel tier = cbxTiere.SelectedItem as IGefluegel;
            if (tier != null)
            {
                // Speicherort abfragen
                SaveFileDialog fileDialog = new SaveFileDialog()
                {
                    Filter = "Hühner|*.hn|Gänse|*.gs|Alles|*.*",
                    FilterIndex = 0
                };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(fileDialog.FileName))
                    {
                        // Tier dort speichern (Serialisierung)
                        XmlSerializer serializer = new XmlSerializer(tier.GetType());
                        serializer.Serialize(writer, tier);
                    }
            }

            }
        }
    }
}
