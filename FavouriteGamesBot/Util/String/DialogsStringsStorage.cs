using System.Reflection.Metadata;
using FavouriteGamesBot.Db.Models;

namespace FavouriteGamesBot.Util.String;

public class DialogsStringsStorage
{
    public const string CommandStartInputErrorInput ="Команда не распознана. Для начала работы с ботом введите /start";

    public const string MainMenu="Выберите действие";

    public const string ListNameInput="Введите название списка";

    public const string ListCreateSuccess="Список создан успешно!";

    public const string MineLists="Ваши списки";

    public static string ChoosedList(GameList gameList){
        return "Выбран список\n\n"+
                $"{gameList.ListName}\n\n"+
                "Выберите действие со списком";
    }
    
    public const string ListPrivacy="Выберите приватность данного списка";

    public static string ListPrivacyInfo(GameList gameList){
        return $"Приватность данного списка {gameList.ListPrivacy}";
    }

    public static string ListPrivacySelected(GameList gameList){
        return $"Ваш список стал {gameList.ListPrivacy}";
    }

    public const string NewListNameInput="Введите новое название списка";

    public const string ListNameChangeSuccess="Название списка успешно изменено!";

    public const string GameNameInput="Введите название игры";

    public const string GamePriceInput="Введите стоимость игры";
   
    public const string GamePriceErrorInput="Некорректная стоимость";

    public const string GameRatingInput="Введите вашу оценку игры. \n(от 0 до 10)";

    public const string GameRatingErrorInput="Некорректная оценка игры";

    public const string GameDescriptionInput="Введите ваш комментарий к данной игре";
    
    public const string ChooseListToAddGame="Выберите список";

    public const string YourLists="Ваши списки";

    public static string CreatedGameParameters(Game game){
        return "Проверьте правильность введённых данных:\n\n"+
                $"Игра: {game.GameName}\n"+
                $"Стоимость: {game.Price}\n"+
                $"Ваша оценка: {game.Rating}\n"+
                $"Ваш комментарий: {game.Description}\n\n"+
                "Данные введены верно?";
    }

    public static string ChoosedGameParameters(Game game){
        return  $"Выбрана игра: {game.GameName}\n"+
                $"Стоимость: {game.Price}\n"+
                $"Ваша оценка: {game.Rating}\n"+
                $"Ваш комментарий: {game.Description}\n\n"+
                "Выберите действие с игрой:";
    }


    public static string GameAdded(Game game){
        return $"Игра {game.GameName} была создана успешно!";
    }

    public const string GamesInList="Ваши игры";

    public static string GameInList(Game game){
        return $"{game.GameName}\n\n";
    }

    public static string ChoosedGame(Game game){
        return "Выбрана игра\n\n"+
        $"{game.GameName}\n\n"+
        "Выберите действие";
    }
}