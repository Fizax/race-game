using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectOnTrigger : MonoBehaviour
{
    public void OnTriggerEnter()
    {
        if (this.enabled)
        {
            if (CheckpointController.currentCheckpoint < 5)
            {
                this.GetComponent<CheckpointController>().addCheckpoint(1);
                this.enabled = false;
            }
        }

        if(CheckpointController.currentCheckpoint >= 5)
        {
            this.GetComponent<LapController>().addLap(1);
            this.GetComponent<CheckpointController>().resetCheckpoint();
        }
    }

}