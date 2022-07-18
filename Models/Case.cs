namespace NWXray.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string ClientFirstname { get; set; } = string.Empty;
        public string ClientLastname { get; set; } = string.Empty;
        public string ClientEmail { get; set; } = string.Empty;
        public string ClientPhone { get; set; } = string.Empty;
        public string ClientAddress { get; set; } = string.Empty;
        public string? ClientInquiry { get; set; }
        public DateTime ClientRequestDatetime { get; set; }
        public string? DealerRespond { get; set; }
        public DateTime DealerRespondDatetime { get; set; }
        public string? DealerUserName { get; set; }

        public Case()
        {
                
        }
    }
}
