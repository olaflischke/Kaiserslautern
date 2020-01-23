using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Ente : Gefluegel
    {
        public Ente():base("Neue Ente")
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
