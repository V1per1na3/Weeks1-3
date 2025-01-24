using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class trickShotmove : MonoBehaviour
{
    public AnimationCurve curve;
    public float Xspeed = 5f;
    public bool ispressing = false;
    [Range(0,1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moveTheStuff();

        Debug.Log(t);


    }

    void moveTheStuff()
    {
        //move
        Vector2 pos = transform.position;
        pos.x += Time.deltaTime * Xspeed;//move in x?
        //check boundaries
        Vector2 screenpos = Camera.main.WorldToScreenPoint(pos);
        if (screenpos.x < 0)
        {
            Vector2 fixpos = new Vector2(0, 0);
            Xspeed = Xspeed * -1;
        }
        if (screenpos.x > Screen.width)
        {
            Vector2 fixpos = new Vector2(Screen.width, 0);
            Xspeed = Xspeed * -1;
        }



        if (Input.GetKey(KeyCode.Space))
        {
            ispressing = true;
        }
        if (ispressing)
        {
            t += Time.deltaTime;
            if (t > 1)
            {
                t = 0;
                ispressing = false;
            }
            
        }
        pos.y = Vector2.one.y * curve.Evaluate(t);
        transform.position = pos;


    }
    

}
