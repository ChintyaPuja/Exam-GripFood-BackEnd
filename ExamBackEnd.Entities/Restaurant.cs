namespace ExamBackEnd.Entities
{
    public class Restaurant
    {
        public string Id { set; get; } = "";
        public string Name { set; get; } = "";
        public List<FoodItem> FoodItems { set; get; } = new List<FoodItem>();
        public List<Cart> Carts { set; get; } = new List<Cart>();
    }
}