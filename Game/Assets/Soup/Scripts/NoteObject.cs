using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    private Rigidbody2D rigid;
    public static int speed;

    private void Start()
    {
        speed = 5;
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigid.velocity = Vector3.down * speed;
    }
}
