using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorHead : MonoBehaviour
{
    public bool enter = true;
    private GameObject[] head;

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
        head = GameObject.FindGameObjectsWithTag("head");

        foreach (GameObject h in head)
        {
            if (collider.tag == "blue")
            {
                h.GetComponent<Renderer>().material.color = Color.blue;
                h.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.blue);
                //Material _material = GetComponent<Renderer>().material;
                //Color _targetColor = Color.blue;
                //_material.SetColor("_EmissionColor", _targetColor);
            }

            if (collider.tag == "white")
            {
                h.GetComponent<Renderer>().material.color = Color.white;
                h.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
                //Material _material = GetComponent<Renderer>().material;
                //Color _targetColor = Color.white;
                //_material.SetColor("_EmissionColor", _targetColor);
            }
        }
    }
}
