using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser2 : MonoBehaviour

{
    Vector2 mousepos;
    float dis = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if (Vector2.Distance(mousepos,pos)<= dis)
        {
            transform.position = new Vector2(Random.Range(-9, 10), Random.Range(-4, 4));

        }

    }
}
