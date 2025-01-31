using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpdemo : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve;
    //public Vector2 start1;
    //public Vector2 end1;
    public Transform start;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        //transform.position = Vector2.one * Mathf.Lerp(-2, 4, t);
        //transform.position = Vector2.Lerp(start1, end1, curve.Evaluate(t));
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
