﻿using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;


namespace AnswerBookBot
{
    class AsyncStereometry
    {
        public static async Task HandleStereometry(ITelegramBotClient botClient, Update update)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {   
                var message = update.Message;
                await botClient.SendTextMessageAsync(message.Chat, "Раздел стериометрии!");
            }
        }
    }
  }
    
  