//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Security.Cryptography;
using UnityEngine;

public class StarAnimation : MonoBehaviour
{
    private SpriteRenderer star;
    private float _movementSpeed = 0.1f;

    void Start()
    {
        star = GetComponent <SpriteRenderer> ();
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong(Time.time/2.5f,1.0f));

        // Move star
        transform.position += transform.up * Time.deltaTime * _movementSpeed; 
    }
}
