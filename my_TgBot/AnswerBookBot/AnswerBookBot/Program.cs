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
        static ITelegramBotClient bot = new TelegramBotClient("5657253659:AAF6QyGwUmeP3uAtvUjMXtjxMKJPk3QG698");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать, любовь, это мой первый ботик!");
                    return;
                }
                if (message.Text.ToLower() == "/коля")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Да это я перейди по ссылке: https://duckduckgo.com/?q=%D0%B6%D0%BE%D0%BF%D0%B0&t=ffab&iax=images&ia=images");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Поцелуй попи");
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
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
  