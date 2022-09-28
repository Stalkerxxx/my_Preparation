using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.ReplyMarkups;


namespace AnswerBookBot
{
    class SectioneSlection
    {

        // token declaration
        //static ITelegramBotClient bot = new TelegramBotClient("5657253659:AAF6QyGwUmeP3uAtvUjMXtjxMKJPk3QG698");

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient,
            Update update, CancellationToken cancellationToken)
        {
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

                if (message.Text.ToLower() == "/geometry")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать в раздел геометрия!!!\n" +
                        "В этом разделе ты можешь считать\n" +
                        "площади и периметры разных фигур из списка:");
                    // await botClient.SendTextMessageAsync(message.Chat, "Чтобы начать введите /goGeometry");
                    await Task.Run(() => HandlePlanemetry(botClient, update, cancellationToken));

                    return;
                }


                if (message.Text.ToLower() == "/answerbook")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать в раздел решебник!!!\n" +
                        "Здесь ты сможешь по тексу задачи получить ссылку на ее решение");
                    return;
                }
                //await botClient.SendTextMessageAsync(message.Chat, "Поцелуй жопу");
            }
        }
        public static async Task HandlePlanemetry(ITelegramBotClient botClient,
           Update update, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                await botClient.SendTextMessageAsync(message.Chat, "Раздел планеметрии!");    
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient,
            Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
    }
}
    
  