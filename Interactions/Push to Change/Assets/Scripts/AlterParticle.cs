using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterParticle : MonoBehaviour {
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var main = ps.main;
        //main.startColor = new Color(hSliderValueR, hSliderValueG, hSliderValueB, hSliderValueA);

        bool buttonAPress = OVRInput.Get(OVRInput.Button.One); 
        bool buttonBPress = OVRInput.Get(OVRInput.Button.Two); 

        if (buttonAPress)
        {
            main.startColor = new Color(1, 0, 1, 1);
        }

        if (buttonBPress)
        {
            main.startColor = new Color(0, 1, 0, 1);
        }
    }
}