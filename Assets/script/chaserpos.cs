using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaserpos : MonoBehaviour
{
    Vector2 mousepos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            transform.position = mousepos;

        }
        
    }
}
