/// <summary>
/// Implementation of the Factory design pattern to create Player objects
/// </summary>
public class PlayerFactory
{
    /// <summary>
    /// Create new player(human) object 
    /// </summary>
    public static BasePlayer GetPlayer(string playerName, GameCorePlayer gameCore)
    {
        return new Player(playerName, gameCore);
    }


    /// <summary>
    /// Create new Bot player(computer) object 
    /// </summary>
    public static BasePlayer GetBotPlayer(GameCorePlayer gameCore)
    {
        return new BotPlayer("Bot", gameCore);
    }
}



