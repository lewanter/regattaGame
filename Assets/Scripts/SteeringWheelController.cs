using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheelController : MonoBehaviour {
    
    public float rotationSpeed;
    //transform
    Transform myTrans;
    //object rotation
    Vector3 myRot;


    // Use this for initialization
    void Start () {
        myTrans = transform;
        myRot = myTrans.rotation.eulerAngles;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        //rotate object Right & Left
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRot.z -= rotationSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRot.z += rotationSpeed;
        }

        myTrans.rotation = Quaternion.Euler(myRot);
    }
}
