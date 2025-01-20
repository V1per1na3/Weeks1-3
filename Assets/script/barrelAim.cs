using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelAim : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousepoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepoint.z = 0;
        transform.right = transform.position - mousepoint;//calculate dir from mouse to object
        
    }

}
