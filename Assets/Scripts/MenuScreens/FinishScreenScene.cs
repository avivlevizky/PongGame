using TMPro;
using UnityEngine;


/// <summary>
/// The finish screen scene when one of the players reached to max score
/// </summary>
public class FinishScreenScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PlayerWonNameText;

    private const string playerWonTextTemplate = "Player {0} Won!";


    private void Start()
    {
        PlayerWonNameText.text = string.Format(playerWonTextTemplate, GameState.PlayerNameWon);
    }

}
