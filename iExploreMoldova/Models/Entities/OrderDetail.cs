namespace iExploreMoldova.Models.Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int LocationId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Location Location { get; set; } = default!;
        public virtual Order Order { get; set; } = default!;
    }
}
