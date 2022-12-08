using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    [Header ("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

     public Transform orientation;

    float hor;
    float vert;

    Vector3 moveDirection;
     Rigidbody rb;

private void Start(){
    rb = GetComponent<Rigidbody>(); // gets rigidbody
    rb.freezeRotation = true; // stops rotation
   
}
//
private void Update(){
    grounded  = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f +0.2f, whatIsGround);
    MyInput();
    SpeedControl();

    if (grounded){
        rb.drag =groundDrag;

    }
    else{
        rb.drag =0;
    }

}

private void FixedUpdate(){
    if(!Input.GetKey(KeyCode.E)){
        
        MovePlayer();
    }
}
private void MyInput()
{
    hor =Input.GetAxisRaw("Horizontal");
    vert= Input.GetAxisRaw("Vertical");

}
private void MovePlayer(){
    // move direction

    moveDirection= orientation.forward * vert + orientation.right * hor;
    // move in direction u look ^

    rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
}
    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
//prevents exceeding max vel
        if (flatVel.magnitude > moveSpeed){
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}
