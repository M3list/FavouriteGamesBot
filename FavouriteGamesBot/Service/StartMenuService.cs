using System;
using FavouriteGamesBot.Bot;
using FavouriteGamesBot.Bot.Router;
using FavouriteGamesBot.Util;
using FavouriteGamesBot.Util.String;

namespace FavouriteGamesBot.Service;

public class StartMenuService
{
    public BotMessage ProcessCommandStart(string textData, TransmittedData transmittedData)
    {
        if (textData == SystemStringsStorage.CommandStart)
        {
        }
        else
        {
        }

        throw new Exception("Неизвестная ошибка в ProcessCommandStart");
    }
}