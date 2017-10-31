using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    //transform
    Transform myTrans;
    //object position
    Vector3 myPos;
    //object rotation
    Vector3 myRot;
    //object rotation 
    float angle;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        myTrans = transform;
        myPos = myTrans.position;
        myRot = myTrans.rotation.eulerAngles;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        angle = myTrans.eulerAngles.magnitude * Mathf.Deg2Rad;
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRot.z -= rotationSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRot.z += rotationSpeed;
        }

        myTrans.rotation = Quaternion.Euler(myRot);
        rb2d.angularVelocity = 0;
      

        //move object Forward & Backward
       // if (Input.GetKey(KeyCode.UpArrow))
        {
            float input = Input.GetAxis("Vertical");
            rb2d.AddForce(gameObject.transform.up * speed * 1);
        }

    }

}
