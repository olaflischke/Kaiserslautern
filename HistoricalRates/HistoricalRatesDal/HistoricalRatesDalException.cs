using System;
using System.Runtime.Serialization;

namespace HistoricalRatesDal
{
    [Serializable]
    public class HistoricalRatesDalException : Exception
    {
        public HistoricalRatesDalException()
        {
        }

        public HistoricalRatesDalException(string message) : base(message)
        {
        }

        public HistoricalRatesDalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HistoricalRatesDalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}