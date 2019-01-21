using System;
using TMPro;
using UnityEngine;


/// <summary>
/// The main class of the Pong game - inject all the relvent gameObject to other components
/// of the program.
/// </summary>
public class GameCore : MonoBehaviour, IGameCore
{
    #region Fields
    [SerializeField] private Paddle _playerPaddle1, _playerPaddle2;
    [SerializeField] private Ball _ball;
    [SerializeField] private KeyConfig _keyConfig;
    [SerializeField] private TextMeshProUGUI _player1Text, _player2Text;  //Represents the players score
    [SerializeField] private int _maxScoreToWin = 12;
    [SerializeField] private SceneLoaderService _sceneLoaderService;
    [SerializeField] private Wall _rightWall;
    [SerializeField] private Wall _leftWall;
    private BasePlayer _player1;
    private BasePlayer _player2;
    private bool _isGameStarted;   //for ball initiate check (handle the initiate key press)
    #endregion



   



    #region Private Methods
    private void Start()
    {
        try
        {
            _isGameStarted = false;
            _rightWall.HitWall += OnHitRightWall;
            _leftWall.HitWall += OnHitLeftWall;
            InitializePlayers();
        }
        catch(Exception exception)
        {
            Debug.Log(exception);
            Debug.LogException(exception);
        }
    }

    private void Update()
    {
        try
        {
            //Call to the two players update method (to update there paddle)
            _player1.Update();
            _player2.Update();

            //If game isn't started and the player/s press on the in InitiateBallKey then the ball
            // will initiate
            if (!_isGameStarted && Input.GetKey(_keyConfig.InitiateBallKey))
            {
                _isGameStarted = true;
                _ball.InitiateBall();
            }

            // Handle the esc key press (menu)
            if (Input.GetKey(_keyConfig.EscKey))
            {
                _sceneLoaderService.LoadMenuScene();
            }
        }
        catch (Exception exception)
        {
            Debug.Log(exception);
            Debug.LogException(exception);
        }
    }


    /// <summary>
    /// Handler for HitWall event (the left wall), call the helper method OnHitWall
    /// </summary>
    private void OnHitLeftWall(object obj, EventArgs eventArgs) => OnHitWall(Side.Left);


    /// <summary>
    /// Handler for HitWall event (the right wall), call the helper method OnHitWall
    /// </summary>
    private void OnHitRightWall(object obj, EventArgs eventArgs) => OnHitWall(Side.Right);


    /// <summary>
    /// The true handler for the hit wall, the method wll checks if the curret player
    /// score is reached to maxScoreToWin (will load the finish screen) otherwise 
    /// the game will reset the ball (and initiate it)
    /// </summary>
    /// <param name="sideWall">The side of hitted wall</param>
    private void OnHitWall(Side sideWall)
    {
        BasePlayer player = sideWall == Side.Left ? _player2 : _player1;
        if (++player.Score == _maxScoreToWin)
        {
            GameState.PlayerNameWon = player.PlayerName;
            _sceneLoaderService.LoadFinishScene();
        }
        else
        {
            _ball.ResetBallCenterPosition(sideWall);
        }
    }

    /// <summary>
    /// Helper method that initialize all the relevent players comonents and resolve the
    /// players objects
    /// </summary>
    private void InitializePlayers()
    {
        IGameCorePlayer gameCorePlayer1 = GameCorePlayerFactory.GetGameCorePlayer(this, Side.Left);
        IGameCorePlayer gameCorePlayer2 = GameCorePlayerFactory.GetGameCorePlayer(this, Side.Right);

        _player1 = PlayerFactory.GetPlayer("Player1", gameCorePlayer1);

        _player2 = GameState.GameMode == GameMode.TwoPlayers ?
            PlayerFactory.GetPlayer("Player2", gameCorePlayer2) :
            PlayerFactory.GetBotPlayer(gameCorePlayer2);
    }



    #region IGameCore Implementation
    public Paddle GetPlayerPaddle1() => _playerPaddle1; 
    public Paddle GetPlayerPaddle2() => _playerPaddle2; 
    public KeyConfig GetKeyConfig() => _keyConfig; 
    public Ball GetBall() => _ball;
    public TextMeshProUGUI GetPlayer1Text() => _player1Text; 
    public TextMeshProUGUI GetPlayer2Text() => _player2Text;
    #endregion



    

    
    #endregion

}
