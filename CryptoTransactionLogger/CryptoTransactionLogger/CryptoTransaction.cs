using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTransactionLogger
{
    public class CryptoTransaction 
    {
        private readonly ILogger _logger;
        public CryptoTransaction(ILogger logger)
        {
            _logger = logger; 
        }

        public void Buy(string currency, double amount)
        {
            if (string.IsNullOrEmpty(currency))
            {
                throw new ArgumentException("Currency cannot be null or empty", nameof(currency));
            }
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero", nameof(amount));
            }
            _logger.Log($"Bought {amount} of {currency}");
        }
        public void Sell(string currency, double amount)
        {
            if (string.IsNullOrEmpty(currency))
            {
                throw new ArgumentException("Currency cannot be null or empty", nameof(currency));
            }
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero", nameof(amount));
            }
            _logger.Log($"Sold {amount} of {currency}");
        }
        public void Transfer(string fromCurrency, string toCurrency, double amount)
        {
            if (string.IsNullOrEmpty(fromCurrency))
            {
                throw new ArgumentException("From currency cannot be null or empty", nameof(fromCurrency));
            }
            if (string.IsNullOrEmpty(toCurrency))
            {
                throw new ArgumentException("To currency cannot be null or empty", nameof(toCurrency));
            }
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero", nameof(amount));
            }
            _logger.Log($"Transferred {amount} from {fromCurrency} to {toCurrency}");
        }
    }
}
