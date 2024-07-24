using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Note : MonoBehaviour
{
    private Rigidbody2D rigid;
    [SerializeField]
    private float speed;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigid.velocity = Vector3.down * speed;
        if(transform.position.y <= 0f)
        {
            if (tag == "Atile")
            {
                if (Input.GetKey("a"))
                {
                    Judgement.TimeCheck(gameObject);
                }
            }
            else if (tag == "Stile")
            {
                if (Input.GetKey("s"))
                {
                    Judgement.TimeCheck(gameObject);
                }
            }
            else if (tag == "Jtile")
            {
                if (Input.GetKey("j"))
                {
                    Judgement.TimeCheck(gameObject);
                }
            }
            else if (tag == "Ktile")
            {
                if (Input.GetKey("k"))
                {
                    Judgement.TimeCheck(gameObject);
                }
            }
        }
        if (transform.position.y < -8)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
