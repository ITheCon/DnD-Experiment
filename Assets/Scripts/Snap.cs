using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) == false)
        {
            transform.position = snap(transform.parent.position);
        }
    }

    Vector2 snap(Vector2 v)
    {
        Vector2 temp = v;
        temp.x = Mathf.Round(temp.x);
        temp.y = Mathf.Round(temp.y);
        return v = temp;
    }

    void adjustSprite()
    {
        //cellSprite = GetComponent<Sprite>();
    }
}
