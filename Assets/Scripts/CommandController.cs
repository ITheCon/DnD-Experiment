using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CommandController : MonoBehaviour {

    private List<GameObject> listeners = new List<GameObject>();

    public Text textOutput;


	// Use this for initialization
	void Start ()
    {
        textOutput.text = "";
        AddListener(gameObject);
	}
	
    public void AddListener(GameObject listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }

    public void Command(string input)
    {
        //name.method(input)
        //Debug.Log(hello)

        string[] parts = input.Split(new char[] { '.', '(', ')' }, 4);
        GameObject go = listeners.Where(obj => obj.name == parts[0]).SingleOrDefault();
        if (go != null)
        {
            go.SendMessage(parts[1], parts[2]);
        }
    }

    public void CreateSphere(string input)
    {
        textOutput.text += "hello";
    }

	// Update is called once per frame
	void Update () {
		
	}
}
