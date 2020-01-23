using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MondialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load(@"C:\Users\olaf\Downloads\SampleData-master\mondial.xml");

            var q = from xe in document.Root.Descendants()
                    where xe.Name.LocalName == "country"
                    && xe.Attribute("capital") != null
                    && xe.Descendants("city")
                    .Where(cityNode => cityNode.Attribute("id").Value == xe.Attribute("capital")?.Value)
                    .First()
                    .Element("name").Value.StartsWith("B")
                    select new { Land = xe.Elements("name").First().Value };

            foreach (var item in q)
            {
                Console.WriteLine(item.Land);
            }
        }

        static void Main50e6(string[] args)
        {
            XDocument document = XDocument.Load(@"C:\Users\olaf\Downloads\SampleData-master\mondial.xml");

            var q = from xe in document.Root.Descendants()
                    where xe.Name.LocalName == "country"
                            && Convert.ToDouble(xe.Elements("population").Last().Value) > 50e6
                    select new
                    {
                        Name = xe.Elements("name").First().Value,
                        Population = Convert.ToDouble(xe.Elements("population").Last().Value)
                    };

            //Console.WriteLine(q);
            foreach (var item in q)
            {
                //Console.WriteLine("{0}: {1:#,##0} people", item.Name, item.Population);

                Console.WriteLine($"{item.Name}: {item.Population:#,##0} Einwohner");
            }
        }
    }
}
