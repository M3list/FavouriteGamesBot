using FavouriteGamesBot.Bot.Router;
using FavouriteGamesBot.Util;

namespace FavouriteGamesBot.Bot.Service;

public class MainService
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