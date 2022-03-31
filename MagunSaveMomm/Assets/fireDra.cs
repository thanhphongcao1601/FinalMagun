﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireDra : MonoBehaviour
{
    public Rigidbody2D rf2;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rf2 = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        rf2.velocity = (Vector2.left) * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag!="Monster")
        {
            Destroy(this.gameObject);
        }
    }
}
