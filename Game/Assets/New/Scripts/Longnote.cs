using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Longnote : MonoBehaviour
{
    [SerializeField]
    private KeyCode Key;
    private bool ClickTime;
    private HpManage hp;
    private void Start()
    {
        GameObject obj = GameObject.Find("HP");
        if (obj != null)
        {
            hp = obj.GetComponent<HpManage>();
        }
    }

    private void Update()
    {
        if (ClickTime) 
        {
            if (Input.GetKeyDown(Key))
            {
                Combo.ManageCombo("perfect");
                Debug.Log("Perfect");
            }
            if (Input.GetKeyUp(Key))
            {
                Combo.ManageCombo("miss");
                Debug.Log("Miss");
                Destroy(gameObject);
            }
        }

        if(transform.position.y <= -20)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Judgement")
        {
            ClickTime = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }




}
