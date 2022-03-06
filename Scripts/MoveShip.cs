using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Takes in two GameObjects - Ship to be moved, and an empty object holding ports' locations
/// The position is constantly updated to move to the nextPortPos
/// </summary>
public class MoveShip : MonoBehaviour
{
    //ship gameobject to be attached in the inspector
    [SerializeField]
    GameObject objectToMove;

    //parent object that holds all ports
    [SerializeField]
    Transform portsParent;

    Transform[] ports;

    Transform nextPort;
    Vector3 nextPortPos;

    void Start()
    {

        nextPortPos = transform.position;

        //fill array with ports
        ports = portsParent.GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        GoToNextPort();
    }

    //updates position every frame to move towards next port
    void GoToNextPort()
    {
        objectToMove.transform.position = Vector3.Lerp(transform.position, nextPortPos, Time.deltaTime);
    }

    //called by UnityEvent
    //gets the next port from an array and sets the position to use in GoToNextPoint
    public void SetNextPort()
    {
        if (currentPortNumber()+1 < ports.Length)
            nextPort = ports[currentPortNumber() + 1];
        else  //for testing purposes
            nextPort = ports[0];

        nextPortPos = nextPort.position;
    }

    int currentPortNumber()
    {
        return Array.IndexOf(ports, nextPort);
    }
}
