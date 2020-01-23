using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HistoricalRatesDal
{
    public class Archive
    {
        public Archive(string url)
        {
            try
            {
                this.TradingDays = GetDataLinq(url);
                SaveDataToLocalDb();
            }
            catch (HistoricalRatesDalException ex)
            {
                this.TradingDays = GetDataFromLocalDb();
            }

            catch (Exception ex)
            {
                throw new Exception("Fehler beim Initialisieren des Archivs", ex);
            }    
        }

        private void SaveDataToLocalDb()
        {
            ArchiveContext context = new ArchiveContext();

            context.TradingDays.AddRange(this.TradingDays);

            context.SaveChanges();
        }

        private List<TradingDay> GetDataFromLocalDb()
        {
            ArchiveContext context = new ArchiveContext();

            return context.TradingDays.ToList();
        }


        /// <summary>
        /// Lädt Kursdaten aus einer GESMES-XML-Datei.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        /// <exception cref="HistoricalRatesDalException">
        /// Fehlerhafte URL?
        /// </exception>
        private List<TradingDay> GetDataLinq(string url)
        {
            try
            {
                XDocument document = XDocument.Load(url);

                var qCubes = from nd in document.Root.Descendants()
                             where nd.Name.LocalName == "Cube" && nd.Attributes().Any(att => att.Name == "time")
                             select new TradingDay() { Date = Convert.ToDateTime(nd.Attribute("time").Value) };

                List<TradingDay> tradingDays = qCubes.ToList(); //new List<TradingDay>();

                //foreach (var xe in qCubes)
                //{
                //    TradingDay day = new TradingDay() { Date = Convert.ToDateTime(xe.Attribute("time").Value) };
                //    //day.Date = Convert.ToDateTime(xe.Attribute("time").Value);
                //    tradingDays.Add(day);
                //}

                return tradingDays;
            }
            catch  (WebException ex)
            {
                throw new HistoricalRatesDalException("Zugriff aufs Internet fehlgeschlagen", ex);

            }
            catch (Exception ex)
            {
                throw new Exception("WHAT!!!???!!", ex);
            }
            finally
            {
                // wird immer ausgeführt
            }


        }

        private List<TradingDay> GetData(string url)
        {
            List<TradingDay> liste = new List<TradingDay>();

            // Read XML
            XmlReader reader = XmlReader.Create(url);

            while (reader.Read())
            {
                TradingDay tradingDay = null;

                // Fill Model
                if (reader.Name == "Cube")
                {
                    if (reader.AttributeCount == 1)
                    {
                        tradingDay = new TradingDay();
                        tradingDay.Date = Convert.ToDateTime(reader.GetAttribute("time"));
                    }
                    if (reader.AttributeCount == 2)
                    {

                    }
                    // ...
                    liste.Add(tradingDay);
                }

            }


            return liste;
        }

        public List<TradingDay> TradingDays { get; set; }


    }
}
