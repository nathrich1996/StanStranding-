﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + GameController.StrandsCollected.ToString() + "/4";
    }
}
