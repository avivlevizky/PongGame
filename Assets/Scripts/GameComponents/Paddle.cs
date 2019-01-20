using UnityEngine;


/// <summary>
/// Represent the player's paddle gameObject in the Pong game
/// </summary>
public class Paddle : MonoBehaviour
{
    #region Public Fields
    public float screenHightInUnits = 11f; //Represent the number of units of the hight's screen
    public float minY = 1.1f;     //The min y-axis threshold of the paddle
    public float maxY = 9.7f;     //The max y-axis threshold of the paddle
    public Side paddleSide;
    #endregion




}