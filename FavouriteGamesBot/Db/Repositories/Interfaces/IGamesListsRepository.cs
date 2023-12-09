using System.Collections.Generic;
using FavouriteGamesBot.Db.Models;

namespace FavouriteGamesBot.Db.Repositories.Interfaces;

public interface IGamesListsRepository
{
    List<GamesList> GetGamesListsByChatId(long chatId);
}