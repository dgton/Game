using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FNote : MonoBehaviour
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
                if (Mathf.Abs(transform.position.y) - 2 < 0.5f)
                    Combo.ManageCombo("perfect");
                else if (Mathf.Abs(transform.position.y) - 2 < 0.75f)
                    Combo.ManageCombo("great");
                else if (Mathf.Abs(transform.position.y) - 2 < 1f)
                    Combo.ManageCombo("good");
                if (colliders != null)
                {
                    colliders.tag = "Judgement";
                }
                gameObject.SetActive(false);
            }
        }
        if (transform.position.y <= -20)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Judgement")
        {
            colliders = collision;
            collision.tag = "using";
            ClickTime = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Judgement")
        {
            if (gameObject.activeSelf)
            {
                collision.tag = "Judgement";
                gameObject.SetActive(false);
                Combo.ManageCombo("miss");
                hp.HPmanage(2f);
            }
        }
    }


}
