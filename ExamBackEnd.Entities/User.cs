namespace ExamBackEnd.Entities
{
    public class User
    {
        public string Id { set; get; } = "";
        public string Name { set; get; } = "";
        public string Email { set; get; } = "";
        public  List<Cart> Carts { set; get; } = new List<Cart>();
    }
}