using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendSwords : MonoBehaviour {

    private float lengthOfTime = 1.0f;
    private float startTime;
    private Vector3 baseSize;
    private Vector3 maxSize;
    private bool isGrowing;
    Renderer m_ObjectRenderer;

    // Use this for initialization
    void Start () {
       
    }

    // Update is called once per frame
    void Update () {
        OVRInput.Update();

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) == false) {
            transform.localScale = new Vector3(0.03F, 0.03F, 0.03F);

            Color textureColor = GetComponent<Renderer>().material.color;
            textureColor.a = 0.5F;
            GetComponent<Renderer>().material.color = textureColor;
        }

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            transform.localScale = new Vector3(0.03F, 0.03F, 0.25F);
            Color textureColor = GetComponent<Renderer>().material.color;
            textureColor.a = 0.75F;
            GetComponent<Renderer>().material.color = textureColor;

            if (OVRInput.Get(OVRInput.RawButton.LHandTrigger) == true)
            {
                transform.localScale = new Vector3(0.03F, 0.03F, 0.5F);
                textureColor.a = 1;
                GetComponent<Renderer>().material.color = textureColor;
            }
        }

        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) == false)
        {
            GameObject.Find("SwordR").transform.localScale = new Vector3(0.03F, 0.03F, 0.03F);
            Color textureColorR = GameObject.Find("SwordR").GetComponent<Renderer>().material.color;
            textureColorR.a = 0.5F;
            GameObject.Find("SwordR").GetComponent<Renderer>().material.color = textureColorR;
        }

        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            GameObject.Find("SwordR").transform.localScale = new Vector3(0.03F, 0.03F, 0.25F);

            Color textureColorR = GameObject.Find("SwordR").GetComponent<Renderer>().material.color;
            textureColorR.a = 0.75F;
            GameObject.Find("SwordR").GetComponent<Renderer>().material.color = textureColorR;

            if (OVRInput.Get(OVRInput.RawButton.RHandTrigger)) {
                GameObject.Find("SwordR").transform.localScale = new Vector3(0.03F, 0.03F, 0.5F);

                textureColorR.a = 1;
                GameObject.Find("SwordR").GetComponent<Renderer>().material.color = textureColorR;
            }
        }
    }
}
