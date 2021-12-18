using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Dynamic Allocation over here
        Vector2 velocity = new Vector2();

        float speed = 200.0f;
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += speed * Time.deltaTime;
        }

        rigidBody.AddForce(velocity);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            rigidBody.AddForce(rigidBody.velocity * 50.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
