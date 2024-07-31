using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Print : MonoBehaviour
{
    private static TextMeshProUGUI Text;

    private void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    public static void printJudgement(string _Judge)
    {
        if(_Judge == "Perfect")
        {
            Text.color = Color.green;
            Text.text = "PERFECT";
        }
        else if(_Judge == "Great")
        {
            Text.color = new Color(1f, 0f, 0.8308458f, 1f);
            Text.text = "GREAT";
        }
        else if( _Judge == "Good")
        {
            Text.color = Color.blue;
            Text.text = "GOOD";
        }
        else if(_Judge == "Miss")
        {
            Text.color = Color.gray;
            Text.text = "MISS";
        }
    }
}
