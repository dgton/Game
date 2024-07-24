using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgement : MonoBehaviour
{
    
    public static void TimeCheck(GameObject Note)
    {
        if(Note.transform.position.y <= -3.8f && Note.transform.position.y >= -4.2f)
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
        else
        {
            Draw.DrawText("Miss");
            Destroy(Note.gameObject);
        }
    }
}
