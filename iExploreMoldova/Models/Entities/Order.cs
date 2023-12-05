namespace iExploreMoldova.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetailsList { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTimeOffset OrderPlaced { get; set; }

    }
}
