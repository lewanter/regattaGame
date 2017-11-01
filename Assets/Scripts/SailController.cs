using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailController : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject player;
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
        
       // myRot = player.transform.rotation.eulerAngles;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myRot = myTrans.rotation.eulerAngles;
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
        myTrans.rotation = Quaternion.Euler(myRot);
    }
}
