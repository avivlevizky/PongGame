using TMPro;


/// <summary>
/// Represent all the relevent game's methods for player 
/// </summary>
public interface IGameCorePlayer
{
    Ball GetBall();
    TextMeshProUGUI GetPlayerText();
    Paddle GetPlayerPaddle();
    KeyConfigPlayer GetKeyConfigPlayer();

}