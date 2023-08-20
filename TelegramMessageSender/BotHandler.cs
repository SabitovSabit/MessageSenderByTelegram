using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramMessageSender
{
    public class BotHandler
    {
        public static ITelegramBotClient bot = new TelegramBotClient("6216746998:AAGtiJd4pQTPDRbrOlsAy6vsc_2ru_7VuK4");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {

            var message = update.Message;
            await botClient.SendTextMessageAsync(message.Chat, "salam");
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
    }
}
