using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{

    private float speed;
    private bool move;
    public GameObject point;
    private Vector3 target;
    public bool mouseOver;
 

    // Use this for initialization
    void Start()
    {
        mouseOver = false;
        Physics2D.queriesHitTriggers = true;
        
    }
    void Update()
    {

        if (Input.GetMouseButton(0) == true && mouseOver == true)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = target;
            //Instantiate(point, target, Quaternion.identity);
        }else
        GetComponent<Collider2D>().transform.position = transform.GetChild(0).transform.position;

    }
    void OnMouseEnter()
    {
        mouseOver = true;
    }

    private void OnMouseExit()
    {
        if(Input.GetMouseButton(0) == false)
        mouseOver = false;
    }

}
