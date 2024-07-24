namespace CurrencyExchanger.Models
{
    // Class describes a table "Currencies"
    public class Currency
    {
        public int ID { get; set; }
        public string CurrencyCode { get; set; }
        public string FullName { get; set; }

        public string CurrencySgin { get; set; }


    }
}
