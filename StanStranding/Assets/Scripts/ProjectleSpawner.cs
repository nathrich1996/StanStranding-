using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectleSpawner : MonoBehaviour
{
    float timer;
    public bool spawnDirection;
    public float spawnPoint;
    public GameObject proj;
    Projectile projectile;
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            SpawnProjectile();
            timer = 0;
            Debug.Log("Spawned Projectile");
        }
    }
    void SpawnProjectile()
    {

        GameObject newProjectile = Instantiate(proj, transform) as GameObject;
        newProjectile.transform.position = transform.position;
        newProjectile.GetComponent<Projectile>().upProjection = spawnDirection;
        
    }
}
