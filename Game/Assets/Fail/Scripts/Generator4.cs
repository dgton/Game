using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Generator4 : Generator1
{
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 8)
        {
            for (int i = 0; i < 1; i++)
            {
                SpawnNote();
            }

            time = 0;
        }
    }


    public override void SpawnNote()
    {
        Vector2 Pos = new Vector2(3f, 8f);
        GameObject Note = Instantiate(NotePrefab);
        Note.transform.position = Pos;
        Note.tag = "Ktile";
    }
}
