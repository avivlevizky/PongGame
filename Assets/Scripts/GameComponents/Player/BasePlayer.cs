using UnityEngine;

/// <summary>
/// Abstract class that represent the basic model of Player 
/// </summary>
public abstract class BasePlayer
{

    #region Fields
    private Paddle _playerPaddle;
    private int _score;
    private float _paddleMovementScale;
    protected GameCorePlayer gameCore;
    #endregion

    #region Properties
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            gameCore.GetPlayerText().text = Score.ToString();
        }
            
    }
    public string PlayerName { get; }
    #endregion

    #region Ctor
    /// <summary>
    /// BasePlayer constructor
    /// </summary>
    /// <param name="playerName">The name of the given player</param>
    /// <param name="core">The given GameCorePlayer contains all the relevent methods for Player Object</param>
    public BasePlayer(string playerName, GameCorePlayer core) : base()
    {
        PlayerName = playerName;
        gameCore = core;
        _playerPaddle = gameCore.GetPlayerPaddle();
        _score = 0;
        _paddleMovementScale = 0.2f;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Public methods that will call from Update (of MonoBehaviour method) and will cause to update the transformation of the
    /// player's paddle
    /// </summary>
    public void Update()
    {
        // In the case that up key was pressed then the player's paddle will go up
        if (IsUpKeyPressed())
        {
            Vector2 vector = new Vector2(_playerPaddle.transform.position.x,
                Mathf.Clamp(_playerPaddle.transform.position.y + _paddleMovementScale, _playerPaddle.minY, _playerPaddle.maxY));
            _playerPaddle.transform.position = vector;
        }

        // In the case that down key was pressed then the player's paddle will go down
        if (IsDownKeyPressed())
        {
            Vector2 vector = new Vector2(_playerPaddle.transform.position.x,
                Mathf.Clamp(_playerPaddle.transform.position.y - _paddleMovementScale, _playerPaddle.minY, _playerPaddle.maxY));
            _playerPaddle.transform.position = vector;
        }
    }
    #endregion

    #region Abstract Methods
    /// <summary>
    /// Absract method that checks id the up key was pressed
    /// </summary>
    /// <returns>true if up key was pressed otherwise return false</returns>
    protected abstract bool IsUpKeyPressed();

    /// <summary>
    /// Absract method that checks if the down key was pressed
    /// </summary>
    /// <returns>true if down key was pressed otherwise return false</returns>
    protected abstract bool IsDownKeyPressed();
    #endregion

}
