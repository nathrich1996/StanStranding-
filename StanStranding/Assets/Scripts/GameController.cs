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
    }
    public static void CollectedStrand()
    {
        StrandsCollected++;
    }

}
