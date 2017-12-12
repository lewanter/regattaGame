using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Dictionary;

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
    private SailReleaseStage sailStage;
    Animator animator;

    // Use this for initialization
    void Start()
    {
        sailStage = SailReleaseStage.Full;
        rb2d = GetComponent<Rigidbody2D>();
        myTrans = transform;
        myPos = myTrans.position;
        myRot = myTrans.rotation.eulerAngles;
        animator = GetComponent<Animator>();
    }
    bool isright = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        angle = myTrans.eulerAngles.magnitude * Mathf.Deg2Rad;
        int sailStage = animator.GetInteger("releaseStage");
       
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRot.z -= rotationSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRot.z += rotationSpeed;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (sailStage < 1)
            {
                sailStage++;
            }
            Debug.Log(sailStage);
            animator.SetInteger("releaseStage", sailStage);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (sailStage > 0)
            {
                sailStage--;
            }
            Debug.Log(sailStage);
            animator.SetInteger("releaseStage", sailStage);
        }
        if (Input.GetKey(KeyCode.Z))
        {
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
