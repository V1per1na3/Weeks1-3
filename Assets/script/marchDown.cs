using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class marchDown : MonoBehaviour
{
    public AnimationCurve curve;
    int dir = 1;
    float yoffset = 0;
    [Range(0, 1)]
    public float t;
    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        t +=Time.deltaTime*0.2f*dir;
        if (t > 1)
        {
            t = 1;
            dir = -1;
            yoffset -= 1;
            
        }else if (t < 0)
        {
            t = 0;
            dir = 1;
            yoffset -= 1;
        }
        Vector2 pos = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        pos.y += yoffset;

        transform.position = pos;
   

    }
}
