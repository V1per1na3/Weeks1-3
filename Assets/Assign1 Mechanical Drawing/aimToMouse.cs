using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimToMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);//get mouse position in screen
        mouse.z = 0;
        Vector2 dir = mouse - transform.position;//dir of current pos to mouse pos
        transform.right = dir;//point toward mouse
              
    }
}
