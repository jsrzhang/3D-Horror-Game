using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    
    public NavMeshAgent enemy;
    public Transform player;
    public Camera myCam;
    public float t = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
      var  distance = Vector3.Distance(player.transform.position, enemy.transform.position); // tracks player vs enemy location
  
         if(distance < 3){ // SET ENEMY SPEED HERE IF CLOSE
            enemy.speed =10f;
            enemy.angularSpeed =10f;
            if (myCam.fieldOfView > 50){
                myCam.fieldOfView = Mathf.Lerp(myCam.fieldOfView, 50, t *Time.deltaTime);
           }

        }
        else { // SET ENEMY SPEED HERE IF FAR
           enemy.speed =0.5f;
           if (myCam.fieldOfView < 80){
                myCam.fieldOfView = Mathf.Lerp(myCam.fieldOfView, 80, t *Time.deltaTime); //reset fov time.deltatime makes it smoother and less jarring.
           }
        }
    }
}
