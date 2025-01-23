using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newThing = Instantiate(prefab, mouse, Quaternion.identity);
            //Instantiate(prefab, transform);//clone becomes the children of the spawner

            newThing.transform.localScale = Vector3.one * Random.Range(0.75f, 1.5f);//planet with different size
            //newThing.GetComponent<spawnthing>().speed = Random.Range(1f, 5f);
            spawnthing myScript = newThing.GetComponent<spawnthing>();
            if (myScript != null)
            {
                myScript.speed = Random.Range(1f, 5f);
            }

            Destroy(newThing, 5);
        }
    }
}
