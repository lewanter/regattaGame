using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailController : MonoBehaviour
{

    public float rotationSpeed;
    //transform
    Transform myTrans;
    //object rotation
    Vector3 myRot;


    // Use this for initialization
    void Start()
    {
        myTrans = transform;
        myRot = myTrans.rotation.eulerAngles;
    }

    private void Update()
    {
        myRot = myTrans.rotation.eulerAngles;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRot.z += rotationSpeed;
            Rotate();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            myRot.z -= rotationSpeed;
            Rotate();
        }
    }

    void Rotate()
    {
        if (myRot.z > 66)
        {
            myRot.z = 66;
        }
        if (myRot.z < 0)
        {
            myRot.z = 0;
        }
        myTrans.rotation = Quaternion.Euler(myRot);
    }
}
