using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    bool isActivated;
    public GameObject barrier;
    void Start()
    {
        isActivated = false;
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !isActivated)
        {
            isActivated = true;
            barrier.GetComponent<Barrier>().DecreaseSwitch();
            Debug.Log("Switch Activated");
        }
    }

}
