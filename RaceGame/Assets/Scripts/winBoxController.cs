using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winBoxController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Car").SendMessage("Finnish");
    }
}
