using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 movVectorEnemy;
    public float enemySpeed = 3.0f;
    bool isDead;
    void Start()
    {
        movVectorEnemy = new Vector2();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            TrackObject(player);
        }
    }
    void TrackObject(GameObject obj)
    {
        PlayerController pc = obj.GetComponent<PlayerController>();
        movVectorEnemy = pc.transform.position - transform.position;
        transform.Translate(enemySpeed * movVectorEnemy.normalized * Time.deltaTime);
    }
    public void ToggleIsDead()
    {
        if (!isDead)
        {
            isDead = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameController.DecreaseLives();
            ToggleIsDead();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameController.DecreaseLives();
            ToggleIsDead();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Safezone")
        {
            //if (collision.gameObject.GetComponent<Safezone>().isActiveAndEnabled)
            //{
                ToggleIsDead();
                Destroy(gameObject);
            //}
        }
    }
}
