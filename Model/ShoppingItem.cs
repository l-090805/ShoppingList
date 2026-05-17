namespace ShoppingList.Model
{
    public class ShoppingItem
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int quantity { get; set; }
        public bool isBought { get; set; }
    }
}