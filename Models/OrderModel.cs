namespace MenuApi.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ProductIds { get; set; }

        public decimal TotalPrice { get; set; }

        //
        //public List<OrderItemModel> OrderItems { get; set; } = new List<OrderItemModel>();


    }
}
