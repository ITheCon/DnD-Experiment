using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour {
     private float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        keyboardMovement();
        mouseMovement();
	}

    void keyboardMovement()
    {
        Vector3 horizontal = (transform.right * (Input.GetAxis("Horizontal") / 2.0f) * speed * Time.fixedDeltaTime) * 64 * 2;
        Vector3 vertical = (transform.up * (Input.GetAxis("Vertical") / 2.0f) * speed * Time.fixedDeltaTime) * 64 * 2;
        transform.position += horizontal;
        transform.position += vertical;
    }

    void mouseMovement()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f && Camera.main.orthographicSize >= 2.0f)
            Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel");
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f && Camera.main.orthographicSize <= 10.0f)
            Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel");
    }
}
