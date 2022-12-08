using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighting : MonoBehaviour
{
    Light playerLight; 
    public GameObject light1; // all lights in scene minus blue overhead
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;

    public Color white;
    public Color Red;

   


    // Start is called before the first frame update
    void Start()
    {
        playerLight = GetComponent<Light>();
        playerLight.range= 3.5f; 

        // Mathf.PingPong(Time.time, 1);  if you want flashing
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)){
             playerLight.range= 10f; // increase player sight range
             playerLight.color = Color.white; // change player light white

             light1.SetActive(true); // turn on scene lights
             light2.SetActive(true);
             light3.SetActive(true);
             light4.SetActive(true);
             light5.SetActive(true);
          
             
        // value 0-8 light intensity is mult with light colour 
        }
        else{
            playerLight.range= 3.5f; 
            playerLight.color = Color.red; // change light colour back

             light1.SetActive(false); // turn off scene lights
             light2.SetActive(false);
             light3.SetActive(false);
             light4.SetActive(false);
             light5.SetActive(false);
        }
    }
}
 
