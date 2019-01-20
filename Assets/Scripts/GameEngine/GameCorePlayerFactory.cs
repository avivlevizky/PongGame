/// <summary>
/// Implementation of the Factory design pattern to create GameCorePlayer objects
/// </summary>
public class GameCorePlayerFactory
{
    /// <summary>
    /// Create new GameCorePlayer by the given arguments
    /// </summary>
    /// <param name="gameCore"></param>
    /// <param name="sidePlayer">The side of the player in play world</param>
    /// <returns>new GameCorePlayer that matched to the given arguments</returns>
    public static GameCorePlayer GetGameCorePlayer(IGameCore gameCore, Side sidePlayer)
    {
        if (sidePlayer == Side.Left)
        {
            //Create new struct with relevent player keyconfig (left player)
            KeyConfigPlayer keyConfig = new KeyConfigPlayer
            {
                PlayerUpKey = gameCore.GetKeyConfig().LeftPlayerUpKey,
                PlayerDownKey = gameCore.GetKeyConfig().LeftPlayerDownKey
            };

            return new GameCorePlayer(gameCore.GetPlayerPaddle1(), gameCore.GetBall(), keyConfig,
                gameCore.GetPlayer1Text());
        }
        else
        {
            //Create new struct with relevent player keyconfig (left player)
            KeyConfigPlayer keyConfig = new KeyConfigPlayer
            {
                PlayerUpKey = gameCore.GetKeyConfig().RightPlayerUpKey,
                PlayerDownKey = gameCore.GetKeyConfig().RightPlayerDownKey
            };

            return new GameCorePlayer(gameCore.GetPlayerPaddle2(), gameCore.GetBall(), keyConfig,
                 gameCore.GetPlayer2Text());
        }

    }
}
