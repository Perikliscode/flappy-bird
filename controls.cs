using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jump;
    public static bool hit = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(-5, 0, 0);
    }
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
            rb.velocity = (new Vector2(0, jump));
       }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
    }

}
