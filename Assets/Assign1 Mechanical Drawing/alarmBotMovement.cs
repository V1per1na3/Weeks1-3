using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class alarmBotMovement : MonoBehaviour
{
    public AnimationCurve curveY;
    public AnimationCurve curveE;
    public float Yspeed = 2f;
    public float Xspeed = 5f;
    public float explodeSpeed = 0.5f;
    public bool jump = false;
    public bool explode = false;
    float currentx;
    float currenty;
    float jumpy;
    [Range(0, 1)]
    public float t;
    [Range(0, 1)]
    public float e;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.Space))// jump when hit space bar
        {
            jump = true;
        }
        if (jump)
        {
            t += Time.deltaTime* Yspeed;// t increase over time
            if (t > 1)
            {
                t = 0;
                jump = false;//the "jump" is true until t goes back to 0 to make one full cycle
            }
            jumpy= Vector2.one.y * curveY.Evaluate(t);//assign new y value in jump state using animation curve
            pos.y = jumpy;

        }

        if (Input.GetKey(KeyCode.Q))//press Q to explode
        {
            explode = true;   
        }
        if (explode)
        {
            e += Time.deltaTime* explodeSpeed;
            if (e > 1)
            {
                e = 0;
                explode = false;//the "jump" is true until t goes back to 0 to make one full cycle
            }
            currentx = transform.position.x;//store current x value
            pos.x = currentx;//stop at current x value
            currenty = Vector2.one.y * curveE.Evaluate(e);//assign new y value in explode state using animation curve
            pos.y = currenty;

        }
        else
        {
            pos.x += Time.deltaTime * Xspeed;//move in x automatically
                                             //check boundaries
            Vector2 screenpos = Camera.main.WorldToScreenPoint(pos);
            if (screenpos.x < 0)
            {
                Vector2 fixpos = new Vector2(0, 0);
                Xspeed = Xspeed * -1;//reverse dir if hit boundary
            }
            if (screenpos.x > Screen.width)
            {
                Vector2 fixpos = new Vector2(Screen.width, 0);
                Xspeed = Xspeed * -1;//reverse dir if hit boundary
            }
        }

        transform.position = pos;

    }
}
