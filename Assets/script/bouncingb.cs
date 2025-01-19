using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class bouncingb : MonoBehaviour
{

    public float bSpeed = 0;//speed
    public float grav = 0.01f;//gravity

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.y -= Time.deltaTime * bSpeed;
        pos.x += Time.deltaTime* 1.5f;
        bSpeed += grav;
        Vector2 ballinscreenspace = Camera.main.WorldToScreenPoint(pos);
        if (ballinscreenspace.y < 0 || ballinscreenspace.y > Screen.height)
        {
            bSpeed = bSpeed * -0.9f;
            ballinscreenspace.y = Screen.height;
        }
        transform.position = pos;



    }
}

