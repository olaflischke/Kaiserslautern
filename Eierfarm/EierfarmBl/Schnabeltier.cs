using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public class Schnabeltier : Saeugetier, IGefluegel
    {
        public List<Ei> Eier { get; set; }

        public double Gewicht { get; set; }
        public string Name { get; set; }

        public void EiLegen()
        {
            throw new NotImplementedException();
        }

        public void Fressen()
        {
            throw new NotImplementedException();
        }

        public override void Saeugen()
        {
            throw new NotImplementedException();
        }
    }
}