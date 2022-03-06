using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform objectToFollow;
    [SerializeField]
    float zOffset, xOffset = 10f;
    [SerializeField]
    float horizontal = 10f;
    [SerializeField]
    float vertical = 10f;
    [SerializeField]
    float height = 10f;

    void Start()
    {
        
    }


    void Update()
    {
        if (objectToFollow != null)
        {
            transform.LookAt(objectToFollow,Vector3.up);
            transform.position = new Vector3(objectToFollow.position.x + xOffset,
                objectToFollow.position.y + height, objectToFollow.position.z + zOffset);
            transform.rotation = new Quaternion(
                transform.rotation.x + horizontal, transform.rotation.y + vertical, transform.rotation.z, transform.rotation.w);
        }
    }
}
