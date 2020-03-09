using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool isPlayerInZone;
    public GameObject enemy;
    float enemyTimer;
    // Start is called before the first frame update
    void Start()
    {
        isPlayerInZone = false;
        enemyTimer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        enemyTimer += Time.deltaTime;
        if (isPlayerInZone && enemyTimer >= 5f)
        {
            SpawnEnemy();
            enemyTimer = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayerInZone = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isPlayerInZone = false;
        }
    }
    void SpawnEnemy()
    {
        GameObject newProjectile = Instantiate(enemy, transform) as GameObject;
        newProjectile.transform.position = transform.position;
    }
}
