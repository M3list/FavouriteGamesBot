using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace FavouriteGamesBot.Bot;

public class BotInitializer
{
    private TelegramBotClient _botClient;
    private CancellationTokenSource _cancellationTokenSource;

    public BotInitializer()
    {
        _botClient = new TelegramBotClient("6949655126:AAFsR8q0Gt3VKyrJx-G_n78edKGcNXM6shM");
        _cancellationTokenSource = new CancellationTokenSource();
    }
    
    public void Start()
    {
        ReceiverOptions receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        BotRequestHandlers botRequestHandlers = new BotRequestHandlers();

        _botClient.StartReceiving(
            botRequestHandlers.HandleUpdateAsync,
            botRequestHandlers.HandlePollingErrorAsync,
            receiverOptions,
            _cancellationTokenSource.Token
        );
        
    }

    public void Stop()
    {
        _cancellationTokenSource.Cancel();
    }
}