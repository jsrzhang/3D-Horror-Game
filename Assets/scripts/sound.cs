using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource walking;
    // detects whether or not you are walking and stops walking sound
    void Update(){
        if(!Input.GetKey(KeyCode.E)){
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow) ){
                walking.enabled =true;
            }
            else{
            walking.enabled=false;
            }
        }
    }
        

        
}
