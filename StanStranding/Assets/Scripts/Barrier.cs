using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int switches;
    bool isDestroyed = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (!isDestroyed)
        {
            CheckForSwitches();
        }
    }
    public bool GetIfDestroyed()
    {
        return isDestroyed;
    }
    public void DecreaseSwitch()
    {
        switches--;
    }
    public void CheckForSwitches()
    {
        if (switches == 0)
        {
            isDestroyed = true;
            Destroy(gameObject);
        }
    }
}
