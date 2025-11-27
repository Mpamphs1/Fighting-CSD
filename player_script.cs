using UnityEngine;
using System.Collections;

public class player_script : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity=Vector2.right*3f;
        }
        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity=Vector2.left*3f;
        }
        if(Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity=Vector2*3f;
        }
    }

}

