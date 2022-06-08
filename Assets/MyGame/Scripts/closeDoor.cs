using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDoor : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("omgitworks");
        anim.SetBool("collided", true);
    }
}
