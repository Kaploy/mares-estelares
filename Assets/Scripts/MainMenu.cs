using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int sceneIndex;
    //� necess�rio criar nas vari�veis um c�digo que escolha um n�mero aleat�rio entre os leveis "f�ceis" para come�ar
    private void Start()
    {
        PlayerPrefs.SetInt("TutorialHasPlayed", 0);
    }
    public void PlayGame()
    {
        if (PlayerPrefs.GetInt("TutorialHasPlayed", 0) <= 0)
        {
            PlayerPrefs.SetInt("TutorialHasPlayed", 1);
            //SceneManager.LoadScene(1);
        }
        else
        {
            //PlayerPrefs.GetInt("SavedLevel");
            if (PlayerPrefs.GetInt("SavedLevel") > 0)
            {
                SceneManager.LoadScene(PlayerPrefs.GetInt("SavedLevel"));
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
