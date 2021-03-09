using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class OrderItemViewModel
    {
        public Order order { get; set; }
        public Item[] items { get; set; }
    }
}