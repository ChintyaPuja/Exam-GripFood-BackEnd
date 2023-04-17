namespace ExamBackEnd.Entities
{
    public class Cart
    {
        public string Id { get; set; } = "";
        public string UserId { get; set; } = "";
        public string RestaurantId { set; get; } = "";
        public List<CartDetail> CartDetails { set; get; } = new List<CartDetail>();
        public User User { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
    }
}