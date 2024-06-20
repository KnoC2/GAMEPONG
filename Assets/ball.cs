using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    public KeyCode Space = KeyCode.Space;
    public Rigidbody2D rigidbody2D;
    public float speed = 6f;

    void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();
        RandomDirection();

    }

    private void RandomDirection()
    {
        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2D.isKinematic = false;

        Vector2 newBallVector = new Vector2();
        newBallVector.x = Random.Range(0f, 1f);
        newBallVector.y = Random.Range(0f, 1f);
        rigidbody2D.velocity = newBallVector * speed;
    }
      

    void Update()
    {
        if (Input.GetKey(Space)){

            RandomDirection();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RandomDirection();
    }
}
