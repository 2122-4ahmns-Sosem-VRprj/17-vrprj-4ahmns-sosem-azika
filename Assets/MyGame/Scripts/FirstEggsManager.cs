using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEggsManager : MonoBehaviour
{
    public FirstGameEggs EggOne;
    public FirstGameEggs EggTwo;
    public Animator anim;
    
    void Update()
    {
        if (EggOne.Collided && EggOne.Collided)
        {
            anim.SetBool("OpenDoor", true);
        }
    }
}
