using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeblink : MonoBehaviour
{
    public float speed = 0.1f;
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 blink = transform.localScale;
        
        t += Time.deltaTime*speed;//t increases since last frame
        if (t > 1)//t goes back to 0 if exceed 1 so its a cycle
        {
            t = 0;
        }
        blink.y = Vector2.one.y * curve.Evaluate(t);//apply animation curve to scale y (squeeze) base on duration of t
        transform.localScale = blink;

    }
}
