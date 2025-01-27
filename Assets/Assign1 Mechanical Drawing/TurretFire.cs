using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public bool fire = false;
    public Transform start;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetMouseButton(0))//left click to fire
        {
            fire = true;
        }
        if (fire)
        {
            t += Time.deltaTime;// t increase over time
            if (t > 1)
            {
                t = 0;
                fire = false;//the "fire" is true until t goes back to 0 to make one full cycle
            }
            pos = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));//map animation curve to position of these 2 object's transform
            transform.position = pos;

        }
    }
}
