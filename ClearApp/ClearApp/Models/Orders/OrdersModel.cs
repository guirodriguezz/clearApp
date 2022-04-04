using System;

namespace ClearApp.Models.Orders
{
    public class OrdersModel
    {
        public DateTime CreatedAt { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Type { get; set; }
        public string Side { get; set; }
        public string Module { get; set; }
        public string Status { get; set; }
        public string Logo { get; set; }
        public string Id { get; set; }
    }
}