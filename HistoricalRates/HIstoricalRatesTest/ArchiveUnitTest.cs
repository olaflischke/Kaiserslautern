using System;
using HistoricalRatesDal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HistoricalRatesTest
{
    [TestClass]
    public class ArchiveUnitTest
    {
        string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";

        [TestMethod]
        public void ArchiveInit()
        {
            Archive archive = new Archive(url);

            Assert.AreEqual(GetCubeNumber(url), archive.TradingDays.Count);
        }
        
        private int GetCubeNumber(string url)
        {
            return 61;
        }
    }
}
