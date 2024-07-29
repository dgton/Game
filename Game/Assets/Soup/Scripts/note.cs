using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    [SerializeField]
    private KeyCode ClickKey;
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
            if (Input.GetKeyDown(ClickKey))
            {
                gameObject.SetActive(false);
                Combo.ManageCombo("perfect");
            }
        }
        if(transform.position.y <= -20)
            Destroy(gameObject);
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
        if (collision.tag == "Judgement")
        {
            if (gameObject.activeSelf)
            {
                gameObject.SetActive(false);
                Combo.ManageCombo("miss");
                hp.HPmanage(2f);
            }
        }
    }


}
