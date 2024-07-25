using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgement : MonoBehaviour
{
    private static HP hp;
    private void Start()
    {
        hp = GetComponent<HP>();
    }
    public static void TimeCheck(GameObject Note)
    { 
        if (Note.transform.position.y <= -3.6f && Note.transform.position.y >= -4.4f)
        {
            Draw.DrawText("perfect");
            Destroy(Note.gameObject);
        }
        else if(Note.transform.position.y <= -3.2f && Note.transform.position.y >= -4.8f)
        {
            Draw.DrawText("great");
            Destroy(Note.gameObject);
        }
        else if(Note.transform.position.y <= -2.5f && Note.transform.position.y >= -5.5f)
        {
            Draw.DrawText("good");
            Destroy(Note.gameObject);
        }
    }
}
