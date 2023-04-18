using System.Collections.Generic;

namespace TelegramChatHistoryParser.Models
{
    public class FileEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public List<MessageEntity> Messages { get; set; }
    }
}
