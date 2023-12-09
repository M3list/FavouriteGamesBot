using System.Collections.Generic;
using System.Linq;
using FavouriteGamesBot.Db.DbConnector;
using FavouriteGamesBot.Db.Models;
using FavouriteGamesBot.Db.Repositories.Interfaces;

namespace FavouriteGamesBot.Db.Repositories.Implemintations;

public class GamesListsRepository : IGamesListsRepository
{
    private FgbDbContext _dbContext;

    public List<GamesList> GetGamesListsByChatId(long chatId)
    {
        return _dbContext.GamesLists.Where(x => x.ChatId == chatId).ToList();
    }
}