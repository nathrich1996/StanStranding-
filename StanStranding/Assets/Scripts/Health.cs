using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public Text healthText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + GameController.PlayerLives.ToString() + "/5";
    }
}
