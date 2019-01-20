using UnityEngine;


/// <summary>
/// KeyConfig gameObject that represent the configuration keybaord keys of the Pong game
/// </summary>
public class KeyConfig : MonoBehaviour
{
    public KeyCode InitiateBallKey = KeyCode.Space;
    public KeyCode LeftPlayerUpKey = KeyCode.W;
    public KeyCode LeftPlayerDownKey = KeyCode.S;
    public KeyCode RightPlayerUpKey = KeyCode.UpArrow;
    public KeyCode RightPlayerDownKey = KeyCode.DownArrow;
    public KeyCode EscKey = KeyCode.Escape;
}


/// <summary>
/// Struct of the specific key config for some player(the values derived from KeyConfig class)
/// </summary>
public struct KeyConfigPlayer
{
    public KeyCode PlayerUpKey;
    public KeyCode PlayerDownKey;
}