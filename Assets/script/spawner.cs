using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public List<GameObject> spawnedThings;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnedThings = new List<GameObject>();//calling constructor
          
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newThing = Instantiate(prefab, mouse, Quaternion.identity);
            //Instantiate(prefab, transform);//clone becomes the children of the spawner

            spawnedThings.Add(newThing);//add stuff to array list
            

            newThing.transform.localScale = Vector3.one * Random.Range(0.75f, 1.5f);//planet with different size
            //newThing.GetComponent<spawnthing>().speed = Random.Range(1f, 5f);
            spawnthing myScript = newThing.GetComponent<spawnthing>();

            myScript.thingthatspawnedme = this;

            if (myScript != null)
            {
                myScript.speed = Random.Range(1f, 5f);
            }

            //Destroy(newThing, 5);destory after 5s
        }
    }
}
