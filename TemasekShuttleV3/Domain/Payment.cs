namespace TemasekShuttleV3.Domain
{
    public class Payment : BaseDomainModel
    {
        public string? UniquePaymentId { get; set; }
        public string? PaymentType { get; set; }
        public decimal? PaymentAmount { get; set; } //show paymentamount
        public int PaymentAmountId { get; set; } // FK
        public int BookingId { get; set; } //FK 
    }
}
