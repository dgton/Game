using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManage : MonoBehaviour
{
    [SerializeField]
    private float MaxHp;
    [SerializeField]
    private float Hp;
    public Slider slider;


    public void HPmanage(float _damage)
    {
        Hp -= _damage;
        float fp = Hp / MaxHp;
        if(fp <= 0)
        {
            fp = 0;
        }
        slider.value = fp;
    }
}
