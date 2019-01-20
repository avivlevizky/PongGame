using UnityEngine;

/// <summary>
/// BotPlayer class inherit from the BasePlayer class and represent the computer player
/// </summary>
public class BotPlayer : BasePlayer
{
    #region Ctor
    /// <summary>
    /// Constructor for BotPlayer
    /// </summary>
    /// <param name="name">The Player name</param>
    /// <param name="gameCore">The given GameCorePlayer contains all the relevent methods for Player Object</param>
    public BotPlayer(string name, GameCorePlayer gameCore) : base(name, gameCore)
    {
    }
    #endregion

    #region Methods
    /// <summary>
    /// Overridden boolean method from the BasePlayer class that checks if the bot wants to move
    /// the paddle down
    /// </summary>
    /// <returns>return true if bot wants to move down the paddle and otherwise returns false</returns>
    protected override bool IsDownKeyPressed() => isKeyPressed(BotKeyPress.Down);


    /// <summary>
    /// Overridden boolean method from the BasePlayer class that checks if the bot wants to move
    /// the paddle up
    /// </summary>
    /// <returns>return true if bot wants to move up the paddle and otherwise returns false</returns>
    protected override bool IsUpKeyPressed() => isKeyPressed(BotKeyPress.Up);
    #endregion

    #region Helper Functions
    /// <summary>
    /// Checks by the given pressKey if to simulate the key pressed
    /// </summary>
    /// <param name="pressKey"></param>
    /// <returns>Returns true if keys need to be pressed and otherwise returns false</returns>
    private bool isKeyPressed(BotKeyPress pressKey)
    {
        bool ans = false;
        Ball ball = gameCore.GetBall();
        Paddle playerPaddle = gameCore.GetPlayerPaddle();

        // The y axis distance between the ball and the current bot paddle
        float distanceY = ball.transform.position.y - playerPaddle.transform.position.y;

        float ballVelocityX = ball.GetBallVelocityVector().x; 

        // checking by the ball velocity (in x axis) what is the direction of the ball movement
        bool isBallInDirection = playerPaddle.paddleSide == Side.Left ? ballVelocityX < 0 : ballVelocityX > 0;

        // if the ball movement direction is opsite to the location of the current paddle then we can
        // stop and return false answer to the callee method 
        if (!isBallInDirection) return false;

        switch (pressKey)
        {
            case BotKeyPress.Up:
                if (distanceY > 0.9f)
                {
                    //Using the random function we prevent from the bot to be invincible
                    ans = Random.Range(0f, 1f) > 0.1f ? true : false;
                }
                break;
            case BotKeyPress.Down:
                if (distanceY < -0.9f)
                {
                    ans = Random.Range(0f, 1f) > 0.1f ? true : false;
                }
                break;
        }

        return ans;
    }

    #endregion
}
