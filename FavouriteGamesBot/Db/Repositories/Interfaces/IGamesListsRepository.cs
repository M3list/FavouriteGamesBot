using FavouriteGamesBot.Db.Models;

namespace FavouriteGamesBot.Db.Repositories.Interfaces;

public interface IGamesListsRepository
{
    List<GameList> GetGamesListsByChatId(long chatId);
}