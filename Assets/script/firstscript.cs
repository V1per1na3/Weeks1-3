using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed *Time.deltaTime;
        Vector2 squareinscreenspace = Camera.main.WorldToScreenPoint(pos);
        if (squareinscreenspace.x <0 || squareinscreenspace.x > Screen.width )
        {
           speed= speed * -1;
        }
        transform.position = pos;
    }
}
