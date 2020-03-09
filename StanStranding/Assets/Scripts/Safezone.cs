using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safezone : MonoBehaviour
{
    // Start is called before the first frame update
    bool isEnabled;
    void Start()
    {
        isEnabled = false;
        gameObject.SetActive(false);
    }
    public void ActivateZone()
    {
        isEnabled = true;
        gameObject.SetActive(true);
    }
    public void DeactivateZone()
    {
        isEnabled = false;
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isEnabled)
        {
            collision.gameObject.GetComponent<Enemy>().ToggleIsDead();
            Destroy(collision.gameObject);
            Debug.Log("Enemy Triggered");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && isEnabled)
        {
            other.gameObject.GetComponent<Enemy>().ToggleIsDead();
            Destroy(other.gameObject);
            Debug.Log("Enemy Triggered");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isEnabled)
        {
            collision.gameObject.GetComponent<Enemy>().ToggleIsDead();
            Destroy(collision.gameObject);
            Debug.Log("Enemy Triggered");
        }
    }
}
