using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapController : MonoBehaviour
{
    public static int currentLap;
    //public int Lap;
    public Vector3 posistion;

    void Start()
    {
        currentLap = 0;
        posistion = transform.position;
    }

    public void addLap(int value)
    {
        currentLap += value;
        Debug.Log("Lap " + currentLap + " out of 3!");
    }
}
