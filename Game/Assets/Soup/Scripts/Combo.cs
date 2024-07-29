using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Combo : MonoBehaviour
{
    private static int combonum = 0;
    private TextMeshProUGUI txt;
    public static int Perfect = 0;
    public static int Miss = 0;

    private void Start()
    {
        Perfect = 0;
        Miss = 0;
        combonum = 0;
        txt = GetComponent<TextMeshProUGUI>();
        txt.text = "";
    }

    private void Update()
    {
        if(txt.text != "Combo\n    " + combonum.ToString())
        {
            txt.text = "Combo\n    " + combonum.ToString();
        }
    }

    public static void ManageCombo(string _pm)
    {
        if (_pm == "perfect")
        {
            combonum++;
            Perfect++;
        }
        
        else if (_pm == "miss")
        {
            combonum = 0;
            Miss++;
        }
    }
}