using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;


/// <summary>
/// Basic representation of Pong Game model (used to expose the game comopnents to the players
/// objects)
/// </summary>
public interface IGameCore
{
    Paddle GetPlayerPaddle1();
    Paddle GetPlayerPaddle2();
    KeyConfig GetKeyConfig();
    Ball GetBall();
    TextMeshProUGUI GetPlayer1Text();
    TextMeshProUGUI GetPlayer2Text();

}