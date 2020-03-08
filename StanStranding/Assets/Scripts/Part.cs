using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{
    bool isAttached;
    GameObject target;
    Rigidbody2D rb;

    float partSpeed;
    void Start()
    {
        isAttached = false;
        rb = GetComponent<Rigidbody2D>();
        partSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttached)
        {
            //MoveToTarget();
            Vector2 movVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            transform.Translate(partSpeed * movVector.normalized * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Triggered");
            target = other.GetComponent<Strands>().GetTailStrand();
            isAttached = true;
            other.GetComponent<Strands>().InsertStrand(this.gameObject);
        }
    }
    void MoveToTarget()
    {
        PlayerController pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (pc.GetPlayerState() == PlayerState.right)
        {
            if (pc.transform.position.x > transform.position.x)
            {
                rb.MovePosition(new Vector2(transform.position.x + (partSpeed * Time.deltaTime), transform.position.y));
            }
        }
        else if (pc.GetPlayerState() == PlayerState.left)
        {
            if (pc.transform.position.x < transform.position.x)
            {
                rb.MovePosition(new Vector2(transform.position.x - (partSpeed * Time.deltaTime), transform.position.y));
            }
        }
        if (pc.GetPlayerState() == PlayerState.up)
        {
            if (pc.transform.position.y > transform.position.y)
            {
                rb.MovePosition(new Vector2(transform.position.x , transform.position.y + (partSpeed * Time.deltaTime)));
            }
        }
        else if (pc.GetPlayerState() == PlayerState.down)
        {
            if (pc.transform.position.y < transform.position.y)
            {
                rb.MovePosition(new Vector2(transform.position.x, transform.position.y - (partSpeed * Time.deltaTime)));
            }
        }

    }
}
