using TMPro;


/// <summary>
/// Implementation of IGameCorePlayer: this class package all the relevent object for
/// player use
/// </summary>
public class GameCorePlayer : IGameCorePlayer
{
    #region Fields
    private Paddle _playerPaddle;
    private Ball _ball;
    private KeyConfigPlayer _keyConfigPlayer;
    private TextMeshProUGUI _playerText;
    private int _maxScoreToWin;
    #endregion


    #region Ctor
    /// <summary>
    /// Constructor of GameCorePlayer
    /// </summary>
    /// <param name="playerPaddle">The player's paddle</param>
    /// <param name="ball">The pong ball</param>
    /// <param name="keyConfigPlayer">The specific player keyconfig</param>
    /// <param name="playerText">The text score</param>
    public GameCorePlayer(Paddle playerPaddle, Ball ball, KeyConfigPlayer keyConfigPlayer,
        TextMeshProUGUI playerText)
    {
        _playerPaddle = playerPaddle;
        _ball = ball;
        _keyConfigPlayer = keyConfigPlayer;
        _playerText = playerText;
    }
    #endregion



    #region Implement IGameCorePlayer
    public Ball GetBall() => _ball;
    public TextMeshProUGUI GetPlayerText() => _playerText;
    public Paddle GetPlayerPaddle() => _playerPaddle;
    public KeyConfigPlayer GetKeyConfigPlayer() => _keyConfigPlayer;

    #endregion
}

