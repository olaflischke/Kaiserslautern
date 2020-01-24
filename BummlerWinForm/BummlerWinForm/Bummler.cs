using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BummlerWinForm
{
    public class Bummler
    {
        public string Bummeln()
        {
            double s = Wurzelsumme(1e8);
            return "Fertig mit Bummeln.";
        }

        public string Troedeln()
        {
            double s = Wurzelsumme(1e9);
            return "Fertig mit Trödeln.";
        }

        public async Task<string> BummelnAsync()
        {
            double s = await Task.Run(() => Wurzelsumme(1e8));
            return "Fertig mit Bummeln.";
        }

        public async Task<string> TroedelnAsync()
        {
            double s = await Task.Run(() => Wurzelsumme(1e9));
            return "Fertig mit Trödeln.";
        }

        private double Wurzelsumme(double zahl)
        {
            double erg = 0;

            for (int i = 0; i < zahl; i++)
            {
                erg += Math.Sqrt(i);
            }

            return erg;
        }

    }
}
