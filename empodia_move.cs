using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empodia_move : MonoBehaviour
{
    public float movespeed;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= -11)
        {
            Destroy(gameObject);
        }
        
    }

}
