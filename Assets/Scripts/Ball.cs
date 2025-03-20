using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        Vector3 position = transform.position;
        position.x = 2;
        transform.position = position;
        Debug.Log("This is the first script");

        Vector3 scale = transform.localScale;
        scale.x = 2;
        scale.y = 2;
        transform.localScale = scale;

        rb2d.AddForce(new Vector2(Random.Range(3, 5), Random.Range(3, 5)), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
