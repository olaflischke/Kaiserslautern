using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalRatesDal
{
    public class ArchiveContext : DbContext
    {
        public ArchiveContext()
            : base(Properties.Settings.Default.ArchiveDb)
        {

        }

        public DbSet<TradingDay> TradingDays { get; set; }
        public DbSet<Currency> Currencies { get; set; }

    }
}
