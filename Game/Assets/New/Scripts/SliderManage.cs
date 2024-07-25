using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManage : MonoBehaviour
{
    private Slider slider;
    private float fSliderBarTime;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value <= 0)
        {
            transform.Find("Fill Area").gameObject.SetActive(false);
        }
        else
        {
            transform.Find("Fill Area").gameObject.SetActive(true);
        }
    }
}
