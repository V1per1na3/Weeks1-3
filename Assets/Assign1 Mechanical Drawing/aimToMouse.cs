using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimToMouse : MonoBehaviour
{
    public Vector2 top1;
    public Vector2 down1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);//get mouse position in screen
        mouse.z = 0;
        // lerp between 2 dir vector depends on mouse y pos
        Vector2 dir = Vector2.Lerp (down1, top1, mouse.y - transform.position.y);
        transform.right = dir;//point toward mouse
        


    }
}
