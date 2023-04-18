# C# Telegram Chat History Parser

*.NET 6.0 class library and Windows Forms application for parsing chat history or channel from Telegram*

## Usage

```c#
TelegramHistoryParser telegramHistoryParser = new TelegramHistoryParser();

// using text
string jsonText;
FileEntity fileEntity = telegramHistoryParser.Parse(jsonText);

// using stream
Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonText))
fileEntity = telegramHistoryParser.Parse(stream);

// get posts (messages)
List<MessageEntity> messages = fileEntity.Messages;

// get text from post (message)
string postText = messages[0].Text;
```
