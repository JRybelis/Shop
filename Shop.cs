namespace ConsoleShop
{
    internal class Shop
    {
        private readonly string _name;
        public Shop(string name)
        {
            _name = name;
        }

        public Shop() : this("Default")
        {
        }

        public string GetInformation()
        {
            return "Description of the shop.";
        }

        public void ListItems()
        {
            
        }

        public void Buy(string itemName, int i)
        {
            throw new System.NotImplementedException();
        }


        public void LoadItems(string itemName, int quantity)
        {
            // To load items 
        }
    }
}