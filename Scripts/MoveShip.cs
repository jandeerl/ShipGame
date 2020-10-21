using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    [SerializeField]
    GameObject objectToMove;

    // TODO array will be all the children of the parent transform passed here
    [SerializeField]
    Transform[] ports;

    Transform nextPort;
    Vector3 nextPortPos;

    void Start()
    {
        nextPortPos = transform.position;
    }

    void Update()
    {
        GoToNextPoint();
    }

    void GoToNextPoint()
    {
        objectToMove.transform.position = Vector3.Lerp(transform.position, nextPortPos, Time.deltaTime);
    }

    // called by unity event
    public void StartMoving()
    {
        nextPortPos = nextPort.position;
    }


    public void ChooseNextPort(int portNumber)
    {
        if (nextPort != ports[portNumber])
            nextPort = ports[portNumber];
        else
        {
            Array.Reverse(ports);
            nextPort = ports[portNumber];
        }
    }
}
