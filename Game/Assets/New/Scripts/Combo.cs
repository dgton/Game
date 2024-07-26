using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Combo : MonoBehaviour
{
    private static int combonum = 0;
    private TextMeshProUGUI txt;

    private void Start()
    {
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
            combonum++;
        else if (_pm == "miss")
            combonum = 0;
    }
}
