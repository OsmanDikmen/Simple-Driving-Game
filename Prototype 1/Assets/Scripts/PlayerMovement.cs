using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Veriables for Vechile
    private float speed = 15;
    private float turnSpeed = 15.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input for Vehicle
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput =  Input.GetAxis("Vertical");

        //Move Vehichle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turn Vehicle
        transform.Rotate(Vector3.up , Time.deltaTime * turnSpeed * horizontalInput);
    }
}
