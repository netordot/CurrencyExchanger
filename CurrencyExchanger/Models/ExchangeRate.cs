namespace CurrencyExchanger.Models
{
    public class ExchangeRate
    {

        public int ID { get; set; }

        // Внешние ключи на Currency ID
        public int BaseCurrencyID { get; set; }
        public int TargetCurrencyID { get; set; }
        public decimal Rate { get; set; }

    }
}
