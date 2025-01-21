using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class keyboardControl : MonoBehaviour
{
    public float movespeed= 3;
    int dir = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        

        transform.localScale= new Vector2(dir, 2);

        
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= movespeed* Time.deltaTime;
            dir = -2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += movespeed * Time.deltaTime;
            dir = 2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += movespeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            pos.y -= movespeed * Time.deltaTime;

        }

        if (pos.x >= 8)
        {
            pos.x = 8;
        }else if (pos.x <= -8)
        {
            pos.x = -8;
        }
        if (pos.y >= 4.5f)
        {
            pos.y = 4.5f;
        }
        else if (pos.y <= -4.5f)
        {
            pos.y = -4.5f;
        }
        transform.position = pos;
    }
}
