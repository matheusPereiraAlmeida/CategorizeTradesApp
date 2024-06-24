using static CategorizeTradesApp.Enumerations;

namespace CategorizeTradesApp.Interfaces
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; } 
        ETradeClassification TradeClassification { get; }
    }
}
