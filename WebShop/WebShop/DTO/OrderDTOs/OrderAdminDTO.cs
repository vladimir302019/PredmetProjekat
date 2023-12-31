﻿using WebShop.Models;

namespace WebShop.DTO.OrderDTOs
{
    public class OrderAdminDTO
    {
        public long Id { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public double TotalPrice { get; set; }
        public bool Confirmed { get; set; }
        public bool Approved { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public long BuyerId { get; set; }
        public User Buyer { get; set; }
    }
}
