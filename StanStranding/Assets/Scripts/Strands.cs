using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strands : MonoBehaviour
{
    public GameObject headStrand;

    [HideInInspector]
    public List<GameObject> strands;
    int strandsLength;
    // Start is called before the first frame update
    void Start()
    {
        strands.Add(this.gameObject);
        strandsLength = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InsertStrand(GameObject part)
    {
        strands.Add(part);
        strandsLength++;
        Debug.Log("Found a Strand");
    }
    public GameObject GetTailStrand()
    {
        return strands[strands.Count-1];
    }
}
