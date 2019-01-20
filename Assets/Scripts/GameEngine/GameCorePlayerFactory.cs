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
    public static GameCorePlayer GetGameCorePlayer(GameCore gameCore, Side sidePlayer)
    {
        if (sidePlayer == Side.Left)
        {
            //Create new struct with relevent player keyconfig (left player)
            KeyConfigPlayer keyConfig = new KeyConfigPlayer
            {
                PlayerUpKey = gameCore.KeyConfig.LeftPlayerUpKey,
                PlayerDownKey = gameCore.KeyConfig.LeftPlayerDownKey
            };

            return new GameCorePlayer(gameCore.PlayerPaddle1, gameCore.Ball, keyConfig,
                gameCore.Player1Text);
        }
        else
        {
            //Create new struct with relevent player keyconfig (left player)
            KeyConfigPlayer keyConfig = new KeyConfigPlayer
            {
                PlayerUpKey = gameCore.KeyConfig.RightPlayerUpKey,
                PlayerDownKey = gameCore.KeyConfig.RightPlayerDownKey
            };

            return new GameCorePlayer(gameCore.PlayerPaddle2, gameCore.Ball, keyConfig,
                 gameCore.Player2Text);
        }

    }
}
