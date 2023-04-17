namespace Exam_Back_End_Programming_Intermediate.Models
{
    public class FoodItemDataGridModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string RestaurantId { get; set; } = string.Empty;
    }
}
