using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;
using System.Text;
using System.Text.Json;
using TelegramChatHistoryParser.Exceptions;
using TelegramChatHistoryParser.Models;

namespace TelegramChatHistoryParser
{
    public class TelegramHistoryParser
    {
        private readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings();

        public TelegramHistoryParser()
        {
            _jsonSerializerSettings.ContractResolver = new DefaultContractResolver { NamingStrategy = new SnakeCaseNamingStrategy() };
            _jsonSerializerSettings.Formatting = Formatting.Indented;
        }
        
        private FileEntity ParseJson(Stream stream)
        {
            StreamReader streamReader = new StreamReader(stream);
            var result = JsonConvert.DeserializeObject<FileEntity>(streamReader.ReadToEnd(), _jsonSerializerSettings);
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
            return ParseJson(new MemoryStream(Encoding.UTF8.GetBytes(json)));
        }
    }
}
