using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class note : MonoBehaviour
{
    [SerializeField]
    private KeyCode ClickKey;
    private bool ClickTime;
    private HpManage hp;
    private Collider2D colliders;
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
                if (Mathf.Abs(transform.position.y + 2)< 0.5f)
                {
                    Combo.ManageCombo("perfect");
                    Print.printJudgement("Perfect");
                }
                else if (Mathf.Abs(transform.position.y + 2)< 0.75f)
                {
                    Combo.ManageCombo("great");
                    Print.printJudgement("Great");
                }
                else if (Mathf.Abs(transform.position.y + 2) < 1f)
                {
                    Combo.ManageCombo("good");
                    Print.printJudgement("Good");
                }
                if(colliders != null)
                {
                    colliders.tag = "Judgement";
                }
                gameObject.SetActive(false);
            }
        }
        if(hp.Hp <= 0)
        {
            gameObject.SetActive(false);
        }
        if(transform.position.y <= -3.2)
        {
            Combo.ManageCombo("miss");
            Print.printJudgement("Miss");
            hp.HPmanage(2f);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Judgement")
        {
            colliders = collision;
            collision.tag = "using";
            ClickTime = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "using")
        {
            if (gameObject.activeSelf)
            {
                collision.tag = "Judgement";
                gameObject.SetActive(false);
                Combo.ManageCombo("miss");
                Print.printJudgement("Miss");
                hp.HPmanage(2f);
            }
        }
    }


}
