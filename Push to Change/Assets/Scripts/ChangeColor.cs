using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "blue")
        {
            // a rigidbody tagged as "white" hits the sword
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            Material _material = GetComponent<Renderer>().material;
            Color _targetColor = Color.blue;
            _material.SetColor("_EmissionColor", _targetColor);
        }

        if (col.gameObject.tag == "white")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            Material _material = GetComponent<Renderer>().material;
            Color _targetColor = Color.white;
            _material.SetColor("_EmissionColor", _targetColor);
        }
    }
}
