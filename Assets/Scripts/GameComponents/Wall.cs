using System;
using UnityEngine;


/// <summary>
/// Represent the wall gameObject in the Pong game
/// </summary>
public class Wall : MonoBehaviour
{
    #region Public Fields
    public event EventHandler HitWall;   // Event of the ball hit in the wall

    public Side sideWall;
    #endregion



    /// <summary>
    /// This method will help to invoke the HitWall event when the the ball will be hit
    /// in the wall
    /// </summary>
    private void HitWallOccured() => HitWall.Invoke(this, EventArgs.Empty);


    /// <summary>
    /// Handler for the collosion trigger (when the ball hit the wall)
    /// </summary>
    /// <param name="collision">The collider gameObject of the wall</param>
    private void OnTriggerEnter2D(Collider2D collision) => HitWallOccured();
}
