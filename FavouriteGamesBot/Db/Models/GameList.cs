namespace FavouriteGamesBot.Db.Models;

public class GameList{
    public int Id {get; set;}

    public int ChatId {get; set;}

    public string ListName {get; set;}= null!;

    public string ListPrivacy {get; set;}=null!;
    
    public virtual ICollection<Game> Games {get; set;}=new List<Game>();
    
}