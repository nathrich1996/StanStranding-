using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strands : MonoBehaviour
{
    public GameObject headStrand;

    [HideInInspector]
    public List<GameObject> strands;

    public int strandsLength;
    [HideInInspector]
    // Start is called before the first frame update
    void Start()
    {
        strands.Add(this.gameObject);
        strandsLength = 1;
        Debug.Log("Strand Size: " + strands.Count.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InsertStrand(GameObject part)
    {
        strands.Add(part);
        strandsLength++;
        GameController.CollectedStrand();
        Debug.Log("Found a Strand");
        Debug.Log("Strand Size: " + strands.Count.ToString());
    }
    public GameObject GetTailStrand()
    {
        return strands[strands.Count-1];
    }
}
