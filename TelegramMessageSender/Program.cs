using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using TelegramMessageSender;




string date = "2023-06-04T15:49:00Z";

DateTime.TryParse(date, out DateTime parsed);

Console.WriteLine(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:00Z"));

Console.WriteLine(DateTime.Compare(parsed,DateTime.Now));


var cts = new CancellationTokenSource();
var cancellationToken = cts.Token;
var receiverOptions = new ReceiverOptions
{
    AllowedUpdates = { }, 
};
BotHandler.bot.ReceiveAsync(
    BotHandler.HandleUpdateAsync,
    BotHandler.HandleErrorAsync,
    receiverOptions,
    cancellationToken
);
Console.ReadLine();


