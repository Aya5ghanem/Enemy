using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMovement : MonoBehaviour
{
    
    public float speed = 10f;

    private Rigidbody2D myBody;
 
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
        
    }
}
