using DemoAPI.Domain.Entities.Base;

namespace DemoAPI.Domain.Entities
{
    public class Transactions : Entity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
