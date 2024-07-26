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
            rend.color = new Color(0.7216981f, 1f, 0.7788996f, 1f);
        }
        if (Input.GetKeyUp(Key))
        {
            rend.color = new Color(1, 1, 1, 0);
        }
    }
}
