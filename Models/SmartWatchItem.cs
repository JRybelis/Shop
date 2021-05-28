namespace ConsoleShop.Models
{
    public class SmartWatchItem : Base.Item
    {
        public string Brand { get; set; }
        public override string ToDescriptionString()
        {
            return $" Brand name: {Brand}, model: {Name}, price - ${Price}.";
            ;
        }
    }
}
