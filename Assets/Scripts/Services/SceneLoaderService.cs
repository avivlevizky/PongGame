using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// SceneLoaderService help on the transition between the scenes and in addition quit 
/// from the game
/// </summary>
public class SceneLoaderService : MonoBehaviour {

    #region Public Fields
    /*This fields represent the names of all the triple scenes that compose the pong game*/
    public string CoreGameSceneName = "Core Game";
    public string MenuSceneName = "Start Menu";
    public string FinishScreenSceneName = "Finish Screen";
    #endregion

    #region Load Scenes Methods
    public void LoadCoreGameTwoPlayersModeScene()
    {
        GameState.GameMode = GameMode.TwoPlayers;
        SceneManager.LoadScene(CoreGameSceneName);
    }

    public void LoadCoreGameBotModeScene()
    {
        GameState.GameMode = GameMode.BotPlayer;
        SceneManager.LoadScene(CoreGameSceneName);
    }


    public void LoadMenuScene()
    {
        SceneManager.LoadScene(MenuSceneName);
    }


    public void LoadFinishScene()
    {
        SceneManager.LoadScene(FinishScreenSceneName);
    }

    public void LoadGameAgain()
    {
        SceneManager.LoadScene(CoreGameSceneName);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    #endregion

}



