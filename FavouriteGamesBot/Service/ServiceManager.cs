using System;
using System.Collections.Generic;
using FavouriteGamesBot.Bot;
using FavouriteGamesBot.Bot.Router;

namespace FavouriteGamesBot.Service;

public class ServiceManager
{
    private Dictionary<string, Func<string, TransmittedData, BotMessage>>
        _methods;

    public ServiceManager()
    {
        StartMenuService startMenuService = new StartMenuService();

        _methods =
            new Dictionary<string, Func<string, TransmittedData, BotMessage>>();

        _methods[States.StartMenu.CommandStart] = startMenuService.ProcessCommandStart;
    }

    public BotMessage ProcessBotUpdate(string textData, TransmittedData transmittedData)
    {
        Func<string, TransmittedData, BotMessage> serviceMethod = _methods[transmittedData.State];
        return serviceMethod.Invoke(textData, transmittedData);
    }
}