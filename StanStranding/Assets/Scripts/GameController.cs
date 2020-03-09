using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameController
{
    public static int PlayerLives = 5;
    public static int StrandsCollected = 0;
    public static void DecreaseLives ()
    {
        PlayerLives--;
        if (PlayerLives <= 0)
        {
            PlayerLives = 5;
            SceneManager.LoadScene(0);
            
        }
    }
    public static void CollectedStrand()
    {
        StrandsCollected++;
    }

}
