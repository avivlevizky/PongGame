using UnityEngine;

/// <summary>
/// Player class inherit from the BasePlayer class and represent the Human player
/// </summary>
public class Player : BasePlayer
{
    #region Ctor
    /// <summary>
    /// Constructor for Player
    /// </summary>
    /// <param name="name">The Player name</param>
    /// <param name="gameCore">The given GameCorePlayer contains all the relevent methods for Player Object</param>
    public Player(string name, IGameCorePlayer gameCore) : base(name, gameCore)
    {
    }
    #endregion

    #region Methods
    /// <summary>
    /// Overridden boolean method from the BasePlayer class that checks if the player pressed on the
    /// down key
    /// </summary>
    /// <returns>return true if player wants to move down the paddle and otherwise returns false</returns>
    protected override bool IsDownKeyPressed() => Input.GetKey(gameCore.GetKeyConfigPlayer().PlayerDownKey);
    

    /// <summary>
    /// Overridden boolean method from the BasePlayer class that checks if the player pressed on the
    /// up key
    /// </summary>
    /// <returns>return true if player wants to move up the paddle and otherwise returns false</returns>
    protected override bool IsUpKeyPressed() => Input.GetKey(gameCore.GetKeyConfigPlayer().PlayerUpKey);
    #endregion

}