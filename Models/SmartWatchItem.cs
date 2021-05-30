namespace ConsoleShop.Models
{
    public class SmartWatchItem : Base.Item
    {
        public string Brand { get; set; }
        public new string ToDescriptionString()
        {
            return $" Brand name: {Brand}, model: {Name}, price - ${PriceDecimal}.";
            ;
        }
    }
}
