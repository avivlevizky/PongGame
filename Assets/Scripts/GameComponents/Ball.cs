using UnityEngine;

/// <summary>
/// Represent the ball gameObject in the Pong game
/// </summary>
public class Ball : MonoBehaviour
{
    #region Fields
    [SerializeField] private float _initVelocityX = 8f;   //Represent the velocity of the ball in x-axis
    [SerializeField] private float _initVelocityY = 0;   //Represent the velocity of the ball in y-axis
    #endregion

    #region Methods
    /// <summary>
    /// Initiate the ball in the play world by the given velocity argument or the matched field value
    /// </summary>
    /// <param name="velocityX">velocity of the ball in x-axis</param>
    public void InitiateBall(float velocityX = 0)
    {
        velocityX = velocityX == 0 ? _initVelocityX : velocityX;
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, _initVelocityY);
    }


    /// <summary>
    /// Reset the ball in the center of the play world and initiate it to the direction of initiateBallDirection
    /// </summary>
    /// <param name="initiateBallDirection">The side which the ball will be initiate</param>
    public void ResetBallCenterPosition(Side initiateBallDirection)
    {
        transform.position = new Vector2(8f, 6f);
        float velocityX = initiateBallDirection == Side.Left ? _initVelocityX * -1f : _initVelocityX;
        InitiateBall(velocityX);
    }

    /// <summary>
    /// Get the ball's velocity vector
    /// </summary>
    /// <returns>velocity vector</returns>
    public Vector2 GetBallVelocityVector()
    {
        return GetComponent<Rigidbody2D>().velocity;
    }
    #endregion
}
