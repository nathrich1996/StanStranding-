using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState
{
    idle,
    up,
    down,
    left,
    right
}

public class PlayerController : MonoBehaviour
{
    
    Rigidbody2D rbPlayer;
    Vector2 movVector;
    Vector2[] oldPositions;
    PlayerState ps;
    public float speed;
    void Start()
    {
        rbPlayer = gameObject.GetComponent<Rigidbody2D>();
        ps = PlayerState.idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0) //move right 
        {
            ps = PlayerState.right;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0) //move left
        {
            ps = PlayerState.left;
        }
        if (Input.GetAxisRaw("Vertical") > 0) //move up 
        {
            ps = PlayerState.up;
        }
        else if (Input.GetAxisRaw("Vertical") < 0) //move down 
        {
            ps = PlayerState.down;
        }
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0) //Not moving, idle
        {
            ps = PlayerState.idle;
        }
        //Debug.Log("Player State: " + ps.ToString());
    }
    private void FixedUpdate()
    {
        AdjustMovement();
    }
    void AdjustMovement()
    {
        movVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(speed * movVector.normalized * Time.deltaTime);
    }

    public PlayerState GetPlayerState()
    {
        return ps;
    }
    
    public Vector2 ReturnMoveVector()
    {
        return movVector;
    }
}
