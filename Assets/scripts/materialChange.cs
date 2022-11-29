 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
public class materialChange : MonoBehaviour
{
 [SerializeField] private Renderer model; // each one has seperate mat
///serialized field is something u input

   public void Start(){
        Color hue = model.material.color;
       hue.a=1F;
       model.material.color = hue;
   } 
   public void Update() {
       
       if (Input.GetKey(KeyCode.E)){
        Color hue = model.material.color;
        hue.a=.5F;
        model.material.color = hue;
       }
       else{
        Color hue = model.material.color;
        hue.a= 1F;
        model.material.color = hue;
       }
   }
}