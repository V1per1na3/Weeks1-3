using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class chasemouse : MonoBehaviour
{
    float speedr = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 mousepoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        transform.right = pos- mousepoint;//calculate dir from mouse to object

        Vector2 dir = (mousepoint - pos).normalized;
        if (Input.GetMouseButton(0))
        {  
            pos += dir * Time.deltaTime * speedr;
            
        }
        transform.position = pos;


    }
}
