namespace FakeSteam.API.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = new PaymentMethod();
        public User User { get; set; } = new User();
        public double TotalAmount { get; set; }
        public double ShippingCharges { get; set; }
        public double AmountReduced { get; set; }
        public double AmountPaid { get; set; }
        public string CreatedAt { get; set; } = string.Empty;
    }
}
