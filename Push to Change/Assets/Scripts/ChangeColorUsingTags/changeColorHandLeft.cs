using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorHandLeft : MonoBehaviour
{
    public bool enter = true;
    private GameObject[] handLeft;

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
        handLeft = GameObject.FindGameObjectsWithTag("handLeft");

        foreach (GameObject l in handLeft)
        {
            if (collider.tag == "blue")
            {
                l.GetComponent<Renderer>().material.color = Color.blue;
                l.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.blue);
                //Material _material = GetComponent<Renderer>().material;
                //Color _targetColor = Color.blue;
                //_material.SetColor("_EmissionColor", _targetColor);
            }

            if (collider.tag == "white")
            {
                l.GetComponent<Renderer>().material.color = Color.white;
                l.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
                //Material _material = GetComponent<Renderer>().material;
                //Color _targetColor = Color.white;
                //_material.SetColor("_EmissionColor", _targetColor);
            }
        }
    }
}
