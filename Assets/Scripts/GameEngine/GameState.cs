using System;


/// <summary>
/// Singleton Design pattern implementation: GameState represent all details about
/// the current status of the game
/// </summary>
public class GameState
{
    /// <summary>
    /// GameMode help the GameCore to know which players should initilize when tranform from
    /// the menu
    /// </summary>
    public static GameMode GameMode { get; set; }

    /// <summary>
    /// The player name who won the game: help to the finish screen to know who is the player
    /// name
    /// </summary>
    public static string PlayerNameWon { get; set; }
}

