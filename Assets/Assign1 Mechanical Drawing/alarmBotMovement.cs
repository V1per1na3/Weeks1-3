using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class alarmBotMovement : MonoBehaviour
{
    public AnimationCurve curveY;
    public float Yspeed = 2f;
    public float Xspeed = 5f;
    public bool jump = false;
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
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

        }
        pos.y = Vector2.one.y * curveY.Evaluate(t);// //apply animation curve to y axis base on duration of t
        transform.position = pos;

    }
}
