using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithChoices : MonoBehaviour { 
private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void OnCollisionEnter(Collision col)
    {
        var main = ps.main;
        if (col.gameObject.name == "WhiteParticlesSphere")
        {
            main.startColor = new Color(1, 0, 1, 1);
        }

        if (col.gameObject.name == "WhiteParticlesSphere")
        {
            main.startColor = new Color(0, 1, 0, 1);
        }
    }
}