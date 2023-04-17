using System;

namespace TelegramChatHistoryParser.Models
{
    public class MessageEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public DateTime Edited { get; set; }
        public string From { get; set; }
        public string FromId { get; set; }
        public string? Photo { get; set; }
    }
}
