namespace FavouriteGamesBot.Bot.Router;

public class States
{
    public static StartMenu StartMenu { get; } = new ();
    public static MainMenu MainMenu { get; } = new ();
}

public class StartMenu
{
    public string CommandStart { get; } = "CommandStart";
}

public class MainMenu
{
    public string ClickOnInlineButton { get; } = "ClickOnInlineButton";
}