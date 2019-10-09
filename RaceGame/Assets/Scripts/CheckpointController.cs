using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public static int currentCheckpoint;
    public Vector3 position;

    void Start()
    {
        currentCheckpoint = 0;
        position = transform.position;
    }

    public void resetCheckpoint()
    {
        currentCheckpoint -= currentCheckpoint;
        Debug.Log("Checkpoint reset! " + currentCheckpoint);
    }

    public void addCheckpoint(int value)
    {
        currentCheckpoint += value;
        Debug.Log("Checkpoint added! " + currentCheckpoint);
    }

    
}
