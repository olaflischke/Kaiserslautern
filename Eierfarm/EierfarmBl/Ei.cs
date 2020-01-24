using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EierfarmBl
{
    public class Ei
    {
        private Ei()
        {

        }

        /// <summary>
        /// Konstruktor für ein Ei.
        /// </summary>
        /// <param name="mutter">Das Tier, das dieses Ei gelegt hat.</param>
        public Ei(Huhn mutter)
        {
            this.Mutter = mutter;

            Random random = new Random();
            this.Gewicht = random.Next(45, 81);
            this.Farbe = (EiFarbe)random.Next(Enum.GetNames(typeof(EiFarbe)).Count()); // DirectCast - kann Exception auslösen
        }


        #region Properties

        // Backing field für die Gewicht-Property
        private double _gewicht;
        // Öffentlicher Teil der Gewicht-Property

        /// <summary>
        /// Gibt das Gewicht des Eis zurück oder legt es fest.
        /// </summary>
        /// <remarks>
        /// Es sind nur positve Werte zulässig!
        /// </remarks>
        /// <exception cref="Exception">
        /// Beim Zuweisen von Werten <= 0 wird eine Standardexception ausgelöst.
        /// </exception>
        public double Gewicht
        {
            get { return _gewicht; }
            set
            {
                if (value > 0)
                {
                    _gewicht = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        // "Auto-Property"
        // Property mit autom. generiertem Backing Field
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "UID")]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime Legedatum { get; set; } = DateTime.Now;

        [XmlIgnore]
        public Huhn Mutter { get; set; }

        [XmlElement(ElementName = "Color")]
        public EiFarbe Farbe { get; set; }

        //public System.IO.FileInfo Datei { get; set; }

        #endregion

        // Public Feld - nicht zu verwechseln mit einer Property
        public double Gewicht2;
    }

    public enum EiFarbe
    {
        Hell,
        Dunkel,
        Gruen
    }
}
