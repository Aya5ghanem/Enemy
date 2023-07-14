using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehavior : MonoBehaviour
{

    [SerializeField]
    GameObject pointA;
    [SerializeField]
    GameObject pointB;
    [SerializeField]
    float speed;

    private Rigidbody2D rb;
    private Transform currentPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }
    private void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            currentPoint = pointB.transform;
        }
    }
}

