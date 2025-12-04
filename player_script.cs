using UnityEngine;
using System.Collections;
using System.Threading;


public class player_script : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform ts;
    public bool x=false;

    void Start()
    {
        ts = GetComponent<Transform>();
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
        if ((Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.UpArrow))&&x)
        {
            rb.linearVelocity=Vector2.up*5f;
            x=false;
            
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        x=true;
    }

    
}
