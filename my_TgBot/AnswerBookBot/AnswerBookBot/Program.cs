using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;


namespace AnswerBookBot
{
    class Program : SectioneSlection
    {
        static void Main(string[] args)
        {
            ITelegramBotClient bot = new TelegramBotClient("5657253659:AAF6QyGwUmeP3uAtvUjMXtjxMKJPk3QG698");
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
    
  