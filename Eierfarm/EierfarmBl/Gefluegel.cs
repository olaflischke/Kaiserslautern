using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace EierfarmBl
{
    public abstract class Gefluegel : IGefluegel
    {
        //public Gefluegel()
        //{

        //}

        public event EventHandler<GefluegelEventArgs> EigenschaftGeaendert;

        public Gefluegel(string name)
        {
            this.Name = name;
        }

        private void OnEigenschaftGeaendert([CallerMemberName]string propName = "")
        {
            if (EigenschaftGeaendert != null)
            {
                EigenschaftGeaendert(this, new GefluegelEventArgs(propName));
            }
        }

        public List<Ei> Eier { get; set; } = new List<Ei>();

        private double _gewicht;

        public double Gewicht
        {
            get { return _gewicht; }
            set
            {
                _gewicht = value;
                OnEigenschaftGeaendert();
            }
        }

        public Guid Id { get;  set; } = Guid.NewGuid();

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnEigenschaftGeaendert();
            }
        }

        public abstract void Fressen();

        public abstract void EiLegen();

    }

    public class GefluegelEventArgs : EventArgs
    {
        public GefluegelEventArgs(string eigenschaftsName)
        {
            this.GeaenderteEigenschaft = eigenschaftsName;
        }

        public string GeaenderteEigenschaft { get; set; }
    }
}