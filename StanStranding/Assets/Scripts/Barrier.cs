using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int switches;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        CheckForSwitches();
    }
    public void DecreaseSwitch()
    {
        switches--;
    }
    public void CheckForSwitches()
    {
        if (switches == 0)
        {
            Destroy(gameObject);
        }
    }
}
