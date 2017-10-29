using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetTouch(0).deltaPosition.x > 0)
        {
            Debug.Log("right"); 
        }
        if (Input.GetTouch(0).deltaPosition.x < 0)
        {
            Debug.Log("left"); 
        }
        if (Input.GetTouch(0).deltaPosition.y < 0)
        {
            Debug.Log("down"); 
        }
        if (Input.GetTouch(0).deltaPosition.y > 0)
        {
            Debug.Log("up"); 
        }

    }
}
