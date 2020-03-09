using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool upProjection;
    public float projSpeed = 3f;
    Rigidbody2D rb;
    float timer = 0;
    bool isDestroyed;
    // Start is called before the first frame update
    public Projectile()
    {
        upProjection = false;
        isDestroyed = false;
    }
    public Projectile(bool upDirection)
    {
        upProjection = upDirection;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (!isDestroyed)
        {
            timer += Time.deltaTime;
            if (timer >= 2.8f)
            {
                timer = 0;
                Destroy(this.gameObject);
                isDestroyed = true;
            }
        }
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!isDestroyed)
        {
            if (upProjection)
            {
                rb.AddForce(new Vector2(0, projSpeed * Time.deltaTime));
            }
            else
            {
                rb.AddForce(new Vector2(0, -projSpeed * Time.deltaTime));
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameController.DecreaseLives();
            isDestroyed = true;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameController.DecreaseLives();
            isDestroyed = true;
            Destroy(this.gameObject);
        }
    }
}
