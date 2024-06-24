using CategorizeTradesApp.Interfaces;
using static CategorizeTradesApp.Enumerations;

namespace CategorizeTradesApp.Entities
{
    public class HighRiskTrade(double value, string clientSector, DateTime nextPaymentDate) : ITrade
    {
        public double Value { get; } = value;
        public string ClientSector { get; } = clientSector;
        public DateTime NextPaymentDate { get; } = nextPaymentDate;
        public ETradeClassification TradeClassification => ETradeClassification.HIGHRISK;
    }
}
