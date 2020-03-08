using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool upProjection;
    public float projSpeed = 3f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    public Projectile()
    {
        upProjection = false;
    }
    public Projectile(bool upDirection)
    {
        upProjection = upDirection;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Foregroud")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Strand")
        {
            GameController.DecreaseLives();
            Debug.Log("# of Lives: " + GameController.PlayerLives);
            Destroy(gameObject);
        }
    }
}
