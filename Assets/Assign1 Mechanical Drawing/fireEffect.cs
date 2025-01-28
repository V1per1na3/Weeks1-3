using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireEffect : MonoBehaviour
{
   
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public bool fire = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 eff = transform.localScale;
        if (Input.GetMouseButton(0))//left click to startfire effect
        {
            fire = true;
        }
        if (fire)
        {
            t += Time.deltaTime;// t increase over time
            if (t > 1)
            {
                t = 0;
                fire = false;//the "fireeffect" is true until t goes back to 0 to make one full cycle
            }
            
        }
        eff = Vector2.one * curve.Evaluate(t);//apply animation curve to scale base on duration of t
        //start will scale of 0 and then suddenly increase scale to fake a "spawn"
        //I will offset animation curve in inspector for different fireeffect object
        transform.localScale = eff;
    }
}
