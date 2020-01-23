using System;
using System.Collections.Generic;

namespace HistoricalRatesDal
{
    public class TradingDay
    {
        public DateTime Date { get; set; }

        public List<Currency> Currencies { get; set; }
    }
}