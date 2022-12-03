 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;


public class cameraMove : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;
    float xRot;
    float yRot;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //locks to center of screen
        Cursor.visible= false; // cant see
    }

    // Update is called once per frame
    void Update()
    {

        //mouse input call
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * sensY;

        yRot += mouseX; // adds x mouse movement to y
        xRot -= mouseY; // subs y mouse movement from x


        xRot = Mathf.Clamp(xRot, -90f,90f); //clamp sets a range so u cant look more than straight up
        transform.rotation= Quaternion.Euler(xRot,yRot,0); // rotation use quaternion euler.
   
        orientation.rotation = Quaternion.Euler(0,yRot,0);
   }
}
