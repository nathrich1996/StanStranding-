using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Return : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnToGame()
    {
        SceneManager.LoadScene(0);
    }
    
}
