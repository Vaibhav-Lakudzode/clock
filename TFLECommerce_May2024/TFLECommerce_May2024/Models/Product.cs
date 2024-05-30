namespace TFLECommerce_May2024.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float ? Price { get; set; }  //Nullable type
        public int StockAvailable { get;set; }
        public string Name { get; internal set; }
        public string Email { get; internal set; }
        public string Phone { get; internal set; }
    }
}
