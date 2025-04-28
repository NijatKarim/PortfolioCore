namespace PortfolioCore.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageNameSurname { get; set; }
        public string MessageEmail { get; set; }
        public string MessageSubject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime MessageSendDate { get; set; }
        public bool MessageIsRead { get; set; }
    }
}
