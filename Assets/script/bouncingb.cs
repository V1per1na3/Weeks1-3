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

        pos.y -= Time.deltaTime * bSpeed;//move in y axis
        pos.x += Time.deltaTime* 1.5f;//move in x axis
        bSpeed += grav;//update speed
        Vector2 ballinscreenspace = Camera.main.WorldToScreenPoint(pos);
        if (ballinscreenspace.y <= 0)//check if ball hits the ground
        {
            bSpeed = bSpeed * -0.95f;//decrease speed every time ball hits the ground
            ballinscreenspace.y = 0;
        }
        if (ballinscreenspace.x >= Screen.width)
        {
            pos.x = -10;
        }
        transform.position = pos;



    }
}

