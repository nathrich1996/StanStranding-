using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameController
{
    public static int PlayerLives = 3;
    public static void DecreaseLives ()
    {
        PlayerLives--;
    }

}
