using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Threading;

public class Generator1 : MonoBehaviour
{
    public GameObject NotePrefab;
    public float time = 0;
    
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 5)
        {
            for (int i = 0; i < 1; i++)
            {
                SpawnNote();
            }

            time = 0;
        }
    }
    public virtual void SpawnNote()
    {
        Vector2 Pos = new Vector2(-3f, 8f);
        GameObject Note = Instantiate(NotePrefab);
        Note.transform.position = Pos;
        Note.tag = "Atile";
    }
}
