﻿namespace ExamBackEnd.Entities
{
    public class FoodItem
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string RestaurantId { set; get; } = "";
        public List<CartDetail> CartDetails { set; get; } = new List<CartDetail>();
        public Restaurant Restaurant { get; set; } = null!;
    }
}