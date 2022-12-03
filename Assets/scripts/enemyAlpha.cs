using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAlpha : MonoBehaviour
{
   public Material[] material;
   Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>(); // rendererer = game objects renderer
        rend.sharedMaterial = material[0]; // access first mat in array
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.E)){
           rend.sharedMaterial = material[1];
        }
        else{
            rend.sharedMaterial = material[0];
        }
        
    }
}
