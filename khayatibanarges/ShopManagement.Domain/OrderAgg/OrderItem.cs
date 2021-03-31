using _0_Framework.Domain;

namespace ShopManagement.Domain.OrderAgg
{
    public class OrderItem : EntityBase
    {
        public long ProductId { get; private set; }
        public int Count { get; private set; }
        public double UnitPrice { get; private set; }
        public int Discount { get; private set; }
        public int OrderId { get; private set; }
        public Order Order { get; private set; }

        public OrderItem(long productId, int count, double unitPrice, int discount, int orderId)
        {
            ProductId = productId;
            Count = count;
            UnitPrice = unitPrice;
            Discount = discount;
            OrderId = orderId;
        }
    }
}