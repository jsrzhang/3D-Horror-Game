using UnityEngine;


public class materialChange : MonoBehaviour
{
    private GameObject[] tex;
    void Start()
    {
           
    }
    
 
     void Update()
     {
         tex = GameObject.FindGameObjectsWithTag("closedTex");
        if (Input.GetKey(KeyCode.E)){ // mat is see through
            foreach(GameObject closedTex in tex) //access them individually 
                {
                    Renderer r = closedTex.GetComponent<Renderer>();
                    Color newColor = r.material.color; // estab new color for mat
                    newColor.a = 0.1f; // change alpha
                    r.material.color = newColor;
            } 
        }
        else{ // mat is solid 1f
            foreach(GameObject closedTex in tex) //access them individually 
                {
                    Renderer r = closedTex.GetComponent<Renderer>();
                    Color newColor = r.material.color;
                    newColor.a = 1f;
                    r.material.color = newColor;
            } 
        }
     }
 }
        
    






















      //[SerializeField] private Renderer model; // each one has seperate mat
///serialized field is something u input

//    public void Start(){
//         Color hue = model.material.color;
//        hue.a=1F;
//        model.material.color = hue;
//    } 
//    public void Update() {
       
//        if (Input.GetKey(KeyCode.E)){
//         Color hue = model.material.color;
//         hue.a=.5F;
//         model.material.color = hue;
//        }
//        else{
//         Color hue = model.material.color;
//         hue.a= 1F;
//         model.material.color = hue;
//        }
//    }
