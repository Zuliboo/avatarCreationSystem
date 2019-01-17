using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnTrigger : MonoBehaviour
{
    public bool enter = true;

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
        if (collider.tag == "blue")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            Material _material = GetComponent<Renderer>().material;
            Color _targetColor = Color.blue;
            _material.SetColor("_EmissionColor", _targetColor);
            Debug.Log("<color=red>BLUE: </color>AssetBundle not found");
        }

        if (collider.tag == "white")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            Material _material = GetComponent<Renderer>().material;
            Color _targetColor = Color.white;
            _material.SetColor("_EmissionColor", _targetColor);
            Debug.Log("<color=red>WHITE: </color>AssetBundle not found");
        }
    }
}
