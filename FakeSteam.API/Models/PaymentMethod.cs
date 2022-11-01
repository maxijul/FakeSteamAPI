namespace FakeSteam.API.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Type { get; set; } = String.Empty;
        public string Provider { get; set; } = String.Empty;
        public bool Available { get; set; }
        public string Reason { get; set; } = String.Empty;
    }
}
