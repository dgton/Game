using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FNoteObject : MonoBehaviour
{
    private Rigidbody2D rigid;
    public static int speed;

    private void Start()
    {
        speed = 10;
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigid.velocity = Vector3.down * speed;
    }
}
