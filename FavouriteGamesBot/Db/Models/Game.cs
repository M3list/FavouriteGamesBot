namespace FavouriteGamesBot.Db.Models;

public class Game
{
    public int Id { get; set; }

    public int GameListId { get; set; }

    public string GameName { get; set; } = null!;

    public int Price { get; set; }

    public int Rating { get; set; }

    public int Description { get; set; }

}