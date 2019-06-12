using Musaca.Models.Enums;

namespace Musaca.Models
{
    public class Order
    {
        public string Id { get; set; }

        public Status Status { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public User Cashier { get; set; }
    }
}
