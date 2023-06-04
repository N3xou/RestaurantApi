namespace MenuApi.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public List<OrderItemModel> OrderItems { get; set; } = new List<OrderItemModel>();

        public decimal TotalPrice
        {
            get { return OrderItems.Sum(item => item.Price); }
        }
    }
}
