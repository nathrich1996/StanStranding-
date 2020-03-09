using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameController.PlayerLives = 5;
        GameController.StrandsCollected = 0;
    }
    public void QuitGame()
    {
        Application.Quit(); //Quit Game
        Debug.Log("Quit Game");
    }
}
