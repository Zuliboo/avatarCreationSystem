using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorHandRight : MonoBehaviour
{
    public bool enter = true;
    private GameObject[] handRight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        handRight = GameObject.FindGameObjectsWithTag("handRight");

        foreach (GameObject r in handRight)
        {
            if (collider.tag == "blue")
            {
                r.GetComponent<Renderer>().material.color = Color.blue;
                r.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.blue);
                //Material _material = GetComponent<Renderer>().material;
                //Color _targetColor = Color.blue;
                //_material.SetColor("_EmissionColor", _targetColor);
            }

            if (collider.tag == "white")
            {
                r.GetComponent<Renderer>().material.color = Color.white;
                r.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
                //Material _material = GetComponent<Renderer>().material;
                //Color _targetColor = Color.white;
                //_material.SetColor("_EmissionColor", _targetColor);
            }
        }
    }
}
