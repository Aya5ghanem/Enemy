using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitpos : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D RB;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goomba"))
        {
            Destroy(collision.gameObject);
        
        }
    }
}
