using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;


namespace AnswerBookBot
{
    class Program
    {
        // token declaration
        static ITelegramBotClient bot = new TelegramBotClient("5657253659:AAF6QyGwUmeP3uAtvUjMXtjxMKJPk3QG698");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient,
            Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, 
                        "Добро пожаловать, это мой бот!");
                    return;
                }
                if (message.Text.ToLower() == "/коля")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Меня зовут Коля, я помогу тебе))");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Поцелуй жопу");
            }
        }
        public static async Task HandleRequestsAsync(ITelegramBotClient botClient,
            Update update, CancellationToken cancellationToken)
        {
            
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient,
            Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}
  