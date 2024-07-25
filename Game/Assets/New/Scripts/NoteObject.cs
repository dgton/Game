using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    private Rigidbody2D rigid;
    [SerializeField] private int speed;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigid.velocity = Vector3.down * speed;
    }
}
