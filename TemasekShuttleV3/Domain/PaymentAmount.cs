namespace TemasekShuttleV3.Domain
{
    public class PaymentAmount : BaseDomainModel
    {
        public decimal? PeakPrice { get; set; }
        public decimal? NonpeakPrice { get; set; }
    }
}
