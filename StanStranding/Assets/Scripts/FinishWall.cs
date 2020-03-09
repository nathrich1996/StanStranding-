using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWall : MonoBehaviour
{
    bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        if (GameController.StrandsCollected >=4 && !isDead)
        {
            isDead = true;
            Destroy(this.gameObject);
        }
    }
}
