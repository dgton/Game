using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManage : MonoBehaviour
{
    [SerializeField]
    private float MaxHp;
    public float Hp;
    public Slider slider;
    private PanelManager panelManager;

    private void Start()
    {
        GameObject obj = GameObject.Find("Panel");
        if(obj != null)
        {
            panelManager = obj.GetComponent<PanelManager>();
        }
    }
    public void HPmanage(float _damage)
    {
        Hp -= _damage;
        float fp = Hp / MaxHp;
        if(fp <= 0)
        {
            fp = 0;
        }
        slider.value = fp;

        if(Hp <= 0)
        {
            panelManager.ActivePanel("Fail");
        }
    }
}
