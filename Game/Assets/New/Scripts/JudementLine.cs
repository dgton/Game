using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudementLine : MonoBehaviour
{
    private SpriteRenderer rend;
    [SerializeField] private KeyCode Key;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            rend.color = Color.gray;
        }
        if (Input.GetKeyUp(Key))
        {
            rend.color = Color.clear;
        }
    }
}
