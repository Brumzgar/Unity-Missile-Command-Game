using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetFloat("enemyMissilesSpeed", 1);
        print(PlayerPrefs.GetFloat("enemyMissilesSpeed") + " = PlayerPrefs.GetFloat(enemyMissilesSpeed)");
        PlayerPrefs.SetInt("roundNumber", 0);
        print("Reset");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
