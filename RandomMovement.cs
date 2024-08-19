using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
           InvokeRepeating("RandomizeMovement", 0.0f, 0.5f); 
    }

    void RandomizeMovement()
    {
        
        Vector2 randomDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)); 
        randomDirection.Normalize(); 

    
        rb.velocity = randomDirection * moveSpeed;
    }
}
