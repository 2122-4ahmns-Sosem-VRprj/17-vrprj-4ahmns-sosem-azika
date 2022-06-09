using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouMadeIt : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("didCollide");
    }
}
