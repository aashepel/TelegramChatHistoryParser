using System.IO;
using System.Text;
using System.Text.Json;
using TelegramChatHistoryParser.Exceptions;
using TelegramChatHistoryParser.Models;

namespace TelegramChatHistoryParser
{
    public class TelegramHistoryParser
    {
        public TelegramHistoryParser()
        {
        }
        
        private FileEntity ParseJson(Stream stream)
        {
            var result = JsonSerializer.Deserialize<FileEntity>(stream);
            if (result == null)
                throw new InvalidJsonFileException();
            return result;
        }

        public FileEntity Parse(Stream stream)
        {
            return ParseJson(stream);
        }

        public FileEntity Parse(string json)
        {
            return ParseJson(new MemoryStream(Encoding.ASCII.GetBytes(json)));
        }
    }
}
