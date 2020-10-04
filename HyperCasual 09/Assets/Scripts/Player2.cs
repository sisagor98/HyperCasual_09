using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private float speed = 5f;
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}

