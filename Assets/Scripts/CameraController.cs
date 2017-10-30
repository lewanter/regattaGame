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
        Vector3 estimatedPosition = player.transform.position + offset;

        if (estimatedPosition.y >= 14)
        {
            estimatedPosition.y = 14;
        }
        if(estimatedPosition.y <= -14)
        {
            estimatedPosition.y = -14;
        }
        if (estimatedPosition.x >= 26)
        {
            estimatedPosition.x = 26;
        }
        if(estimatedPosition.x <= -26)
        {
            estimatedPosition.x = -26;
        }

        transform.position = estimatedPosition;
    }
}
