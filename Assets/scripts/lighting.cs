using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighting : MonoBehaviour
{
    Light playerLight; 
    // Start is called before the first frame update
    void Start()
    {
        playerLight = GetComponent<Light>();
        playerLight.range= 3; 

        // Mathf.PingPong(Time.time, 1);  if you want flashing
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)){
             playerLight.range= 10f; 
        // value 0-8 light intensity is mult with light colour 
        }
        else{
            playerLight.range= 4f; 
        }
    }
}
