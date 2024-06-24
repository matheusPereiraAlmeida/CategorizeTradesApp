using CategorizeTradesApp.Entities;
using CategorizeTradesApp.Interfaces;

namespace CategorizeTradesApp.Services
{
    public static class TradeFactory
    {
        public static ITrade? CreateTrade(int value, string clientSector, DateTime nextPaymentDate, DateTime referenceDate)
        {
            var paymentMaximum = nextPaymentDate.AddDays(30);

            if (referenceDate > paymentMaximum)
                return new ExpiredTrade(value, clientSector, referenceDate);
            else if (value > 1000000 && clientSector == "Private")
                return new HighRiskTrade(value, clientSector, referenceDate);
            else if (value > 1000000 && clientSector == "Public")
                return new MediumRiskTrade(value, clientSector, referenceDate);

            return null;
        }
    }
}
