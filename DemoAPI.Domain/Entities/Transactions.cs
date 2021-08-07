namespace DemoAPI.Domain.Entities
{
    public class Transactions
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
