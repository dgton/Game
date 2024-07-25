using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Slider slider;
    [SerializeField]
    private float MaxHp;
    [SerializeField]
    private float Hp;
    [SerializeField]
    private float MinusHp;

    public void ManageHp()
    {
        Debug.Log("1");
        Hp -= MinusHp;
        float var = Hp / MaxHp;
        if (var < 0)  
            var = 0;
        slider.value = var;
    }
}
