using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Windows;

public class paddle : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 10;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
     void FixedUpdate()
    {
        rb.velocity = new Vector2(UnityEngine.Input.GetAxis("Horizontal") *speed , 0f);
    }
}
