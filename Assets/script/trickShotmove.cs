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
    public float Yspeed = 5f;
    public Transform start;
    public Transform end;
    float timer = 0;


    [Range(0, 1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveTheStuff();
        jump();
        


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

        transform.position = pos;
    }
    void jump()
    {
  
        if (Input.GetKey(KeyCode.Space))
        {
            timer ++;
            t = timer*Time.deltaTime;
            if (t >1)
            {
                timer = 0;
                
            }
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

        }


    }

}
