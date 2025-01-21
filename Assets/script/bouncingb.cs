using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class bouncingb : MonoBehaviour
{
    public float runspeed = 1.5f;//x speed
    public float bSpeed = 0;//y speed
    public float grav = 0.01f;//gravity
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 bsize = transform.localScale;
        pos.y -= Time.deltaTime * bSpeed;//move in y axis
        pos.x += Time.deltaTime* runspeed;//move in x axis
        bSpeed += grav;//update speed
        Vector2 ballinscreenspace = Camera.main.WorldToScreenPoint(pos);

        if (ballinscreenspace.y < 0)//check if ball hits the ground
        {
            bSpeed = bSpeed * -0.95f;//decrease speed every time ball hits the ground
            
        }
        if (ballinscreenspace.x >= Screen.width)
        {
            pos.x = -9 ;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))//reset ball position
        {
            pos = Vector2.zero;
         
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            runspeed += 0.2f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            runspeed -= 0.2f;
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            bsize.x +=0.5f;
            bsize.y += 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bsize.x -= 0.5f;
            bsize.y -= 0.5f;
        }
        transform.localScale = bsize;
        transform.position = pos;

    }
}

