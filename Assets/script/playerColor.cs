using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerColor : MonoBehaviour {

    public Material[] material; // Material : 
    Renderer rend; // Renderer : 

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "damCol")
        {
            rend.sharedMaterial = material[1];

        }

        Invoke("backToOriginColor", 1);
    }


    void backToOriginColor()
    {
        rend.sharedMaterial = material[0];
    }



}
