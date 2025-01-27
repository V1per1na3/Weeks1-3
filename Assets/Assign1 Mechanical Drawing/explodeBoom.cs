using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class explodeBoom : MonoBehaviour
{
    public float speed = 1f;
    public AnimationCurve curve;
    public bool Bang=false;
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Boom = transform.localScale;
        if (Input.GetKey(KeyCode.Q))//explosion object increase in size when pressing q
        {
            Bang = true;
        }

        if (Bang)
        {
            t += Time.deltaTime * speed;//t increases since last frame
            if (t > 1)//t goes back to 0 if exceed 1 so its a cycle
            {
                t = 0;
                Bang = false;//the "explosion" is true until t goes back to 0 to make one full cycle
            }
        }

        Boom = Vector2.one * curve.Evaluate(t);//apply animation curve to scale base on duration of t
        transform.localScale = Boom;

    }
}
