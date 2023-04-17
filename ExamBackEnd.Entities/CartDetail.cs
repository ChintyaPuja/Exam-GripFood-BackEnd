namespace ExamBackEnd.Entities
{
    public class CartDetail
    {
        public string Id { get; set; } = "";
        public string CartId { get; set; } = "";
        public string FoodItemId { get; set; } = "";
        public int Qty { get; set; }
        public FoodItem FoodItem { get; set; } = null!;
        public Cart Cart { get; set; } = null!;
    }
}