using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    bool isActivated;
    bool firstActivated;
    public Safezone sz;
    public GameObject barrier;
    bool isBarrierDown = false;
    void Start()
    {
        isActivated = false;
        firstActivated = false;
    }
    private void Update()
    {
        if (!isBarrierDown)
        {
            isBarrierDown = barrier.GetComponent<Barrier>().GetIfDestroyed();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !isActivated)
        {
            isActivated = true;
            sz.ActivateZone();
            if (!isBarrierDown && !firstActivated)
            {
                barrier.GetComponent<Barrier>().DecreaseSwitch();
                firstActivated = true;
            }
            Debug.Log("Switch Activated");
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioCotroller>().ChangeToCalm();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && isActivated)
        {
            isActivated = false;
            sz.DeactivateZone();
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioCotroller>().ChangeToTense();
        }
    }

}
