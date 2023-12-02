using FavouriteGamesBot.Bot.Router;

namespace FavouriteGamesBot.Bot.Service;

public class ServiceManager
{
    private Dictionary<string, Func<string, TransmittedData, BotMessage>>
        _methods;

    public ServiceManager()
    {
        MainService mainService = new MainService();

        _methods =
            new Dictionary<string, Func<string, TransmittedData, BotMessage>>();

        _methods[States.WaitingCommandStart] = mainService.ProcessCommandStart;
    }

    public BotMessage ProcessBotUpdate(string textData, TransmittedData transmittedData)
    {
        Func<string, TransmittedData, BotMessage> serviceMethod = _methods[transmittedData.State];
        return serviceMethod.Invoke(textData, transmittedData);
    }
}