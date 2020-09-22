using System.Collections.Generic;

namespace UsingValueObjects.Data.Models
{
    public class Money : ValueObject
    {
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }

        public Money()
        {

        }

        public Money(Currency currency, decimal amount)
        {
            Currency = currency;
            Amount = amount;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Currency;
            yield return Amount;
        }

        public decimal GetRial()
        {
            return Currency switch
            {
                Currency.Toman => Amount * 10,
                Currency.Rial => Amount,
                _ => 0,
            };
        }

        public decimal GetToman()
        {
            return Currency switch
            {
                Currency.Toman => Amount,
                Currency.Rial => Amount / 10,
                _ => 0
            };
        }
    }

    public enum Currency : byte
    {
        Toman = 1,
        Rial = 2,
    }
}