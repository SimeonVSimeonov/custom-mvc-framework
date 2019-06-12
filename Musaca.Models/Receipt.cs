using System;
using System.Collections.Generic;
using System.Text;

namespace Musaca.Models
{
    public class Receipt
    {
        public Receipt()
        {
            this.Orders = new List<Order>();
        }

        public string Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public ICollection<Order> Orders { get; set; }

        public User Cashier { get; set; }
    }
}
