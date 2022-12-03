using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fov : MonoBehaviour
{
   public float maxCamDistance =10f;
   public float minCamFOV =5f;
   public float fovSpeed =1f;

   public Transform target;
   public Camera myCam;

   public float initialFOV;

    void Start()
    {
        myCam =this.GetComponent<Camera>();
        initialFOV = myCam.fieldOfView;
    }
    void ResetFOV(){
        myCam.fieldOfView =initialFOV;
    }
    
    void LateUpdate()
    {
        if (target ==null){
            ResetFOV(); // keeps to initial fov
        }
        else{ // cam is looking at target
            myCam.transform.LookAt(target);
            if (Vector3.Distance(transform.position, target.position)> maxCamDistance){ //if object is far enough
                if(myCam.fieldOfView <= minCamFOV){ // check min distance
                    myCam.fieldOfView = minCamFOV;
                }
                else{
                    myCam.fieldOfView -= fovSpeed;
                }
            }
            else if(Vector3.Distance(transform.position, target.position)< maxCamDistance) // check max fov
            {
                myCam.fieldOfView += fovSpeed;
                if(myCam.fieldOfView >= initialFOV){
                    ResetFOV();
                }
            }
        }
    }
}
