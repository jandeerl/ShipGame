using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform objectToFollow;
    [SerializeField]
    float xOffset = 10f;
    [SerializeField]
    float zOffset = 10f;
    [SerializeField]
    float height = 10f;

    void Start()
    {
        
    }


    void Update()
    {
        if (objectToFollow != null)
        {
            transform.LookAt(objectToFollow);
            transform.position = new Vector3(objectToFollow.position.x + xOffset,
                objectToFollow.position.y + height, objectToFollow.position.z + zOffset);
        }
    }
}
