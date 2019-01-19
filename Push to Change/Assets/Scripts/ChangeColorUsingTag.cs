using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorUsingTag : MonoBehaviour
{
    public bool enter = true;
    private GameObject[] head;
    private GameObject[] handLeft;
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
        head = GameObject.FindGameObjectsWithTag("head");
        handLeft = GameObject.FindGameObjectsWithTag("handLeft");
        handRight = GameObject.FindGameObjectsWithTag("handRight");

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
