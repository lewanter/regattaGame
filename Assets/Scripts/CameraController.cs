using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;


    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    
    void LateUpdate()
    {
        Vector3 newPos = player.transform.position + offset;
        if (transform.position.y >= 14)
        {
            newPos.y = 14;
        }

        transform.position = newPos;
    }
}
