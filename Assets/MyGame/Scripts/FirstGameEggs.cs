using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FirstGameEggs : MonoBehaviour
{
    public GameObject Ei;
    public bool Collided;
    

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Collider")
        {
            Collided = true;
            Debug.Log("is true");
        }
    }
}
