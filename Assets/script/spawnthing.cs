using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnthing : MonoBehaviour
{
    public float speed = 1f;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprite;
    int sortOrder = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,5);
        //spriteRenderer.color = Random.ColorHSV();
        if (sprite.Length == 0)
        {

        }
        else
        {
            spriteRenderer.sprite = sprite[Random.Range(0,sprite.Length)];
            spriteRenderer.sortingOrder = sortOrder++;//not working?


}
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0)
        {
            Vector3 fixedpos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedpos).x;
            speed = speed * -1;
        }

        if (screenPos.x > Screen.width)
        {
            Vector3 fixedpos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedpos).x;
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
