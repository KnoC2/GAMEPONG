using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public SpriteRenderer sprite;
    public Rigidbody2D rigid;

    public float speed = 5f;
    public KeyCode UpKey = KeyCode.W;
    public KeyCode DownKey = KeyCode.S;
    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;  


    // Start is called before the first frame update
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpKey) && transform.position.y < 4f)
        {
            rigid.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(DownKey) && transform.position.y > -4f)
        {
            rigid.velocity = Vector2.down * speed;
        }
        else if (Input.GetKey(LeftKey))
        {
            rigid.velocity = Vector2.left * speed;
        }

        else if (Input.GetKey(RightKey))
        {
            rigid.velocity = Vector2.right * speed;
        }

        else
        {
            rigid.velocity = Vector2.zero;
        }
    }