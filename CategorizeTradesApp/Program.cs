using CategorizeTradesApp.Services;
using System.Globalization;

namespace CategorizeTradesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime referenceDate);
            int.TryParse(Console.ReadLine(), out int tradesQuantity);

            for (int i = 0; i < tradesQuantity; i++)
            {
                var line = Console.ReadLine();                
                if (line == null)
                    break;

                if (string.IsNullOrEmpty(line))
                    throw new Exception("Invalid input");

                string[] parts = line.Split(' ');

                int amount = int.Parse(parts[0]);
                string type = parts[1];
                DateTime.TryParseExact(parts[2], "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

                var trade = TradeFactory.CreateTrade(amount, type, date, referenceDate);

                if(trade != null)
                    Console.WriteLine(trade.TradeClassification.ToString());
            }
        }
    }
}
