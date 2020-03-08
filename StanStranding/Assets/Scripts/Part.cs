using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{
    bool isAttached;
    GameObject target;
    Rigidbody2D rb;
    Vector2 movVectorPart;
    public float partSpeed;
    public float bodySpeedDecrement;
    void Start()
    {
        isAttached = false;
        rb = GetComponent<Rigidbody2D>();
        partSpeed = 4.5f;
        movVectorPart = new Vector2();
        bodySpeedDecrement = .97f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttached)
        {
            MoveToTarget();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Player" && !isAttached)
        {
            Debug.Log("Triggered");
            target = other.GetComponent<Strands>().GetTailStrand();
            isAttached = true;
            other.GetComponent<Strands>().InsertStrand(gameObject);
            transform.position = new Vector2(other.transform.position.x, other.transform.position.y - 2f );

        }
            //if (other.gameObject.tag == "Strand" && isAttached)
            //{
            //    Vector2 bodyMovVector = transform.position - other.transform.position;
            //    transform.position = new Vector2(other.transform.position.x, other.transform.position.y - 2f );
            //    DecreaseSpeed(2.5f);
            //    isAttached = true; 
            //    //other.gameObject.transform.Translate(.005f * -partSpeed * bodyMovVector.normalized * Time.deltaTime);
            //    Debug.Log("Strand Collided");
            //}
    }
    void MoveToTarget()
    {
        PlayerController pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (pc.GetPlayerState() == PlayerState.right)
        {
            if (pc.transform.position.x > transform.position.x)
            {
                movVectorPart = target.transform.position - transform.position;
                transform.Translate(bodySpeedDecrement * partSpeed * movVectorPart.normalized * Time.deltaTime);
            }
        }
        else if (pc.GetPlayerState() == PlayerState.left)
        {
            if (pc.transform.position.x < transform.position.x)
            {
                movVectorPart = target.transform.position - transform.position;
                transform.Translate(bodySpeedDecrement * partSpeed * movVectorPart.normalized * Time.deltaTime);
            }
        }
        if (pc.GetPlayerState() == PlayerState.up)
        {
            if (pc.transform.position.y > transform.position.y)
            {
                movVectorPart = target.transform.position - transform.position;
                transform.Translate(bodySpeedDecrement * partSpeed * movVectorPart.normalized * Time.deltaTime);
            }
        }
        else if (pc.GetPlayerState() == PlayerState.down)
        {
            if (pc.transform.position.y < transform.position.y)
            {
                movVectorPart = target.transform.position - transform.position;
                transform.Translate(bodySpeedDecrement * partSpeed * movVectorPart.normalized * Time.deltaTime);
            }
        }

    }
    public void DecreaseSpeed(float val)
    {
        partSpeed -= val;
        bodySpeedDecrement -= .01f;
    }
}
