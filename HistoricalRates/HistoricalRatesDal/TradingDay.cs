using System;
using System.Collections.Generic;

namespace HistoricalRatesDal
{
    public class TradingDay
    {
        public int TradingDayId { get; set; }

        public DateTime Date { get; set; }

        public List<Currency> Currencies { get; set; }

        public string TradingLocation { get; set; }
    }
}