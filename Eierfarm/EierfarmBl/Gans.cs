using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public class Gans : Gefluegel
    {
        public Gans(string name) : base(name)
        {
        }

        public override void EiLegen()
        {
            throw new NotImplementedException();
        }

        public override void Fressen()
        {
            throw new NotImplementedException();
        }
    }
}