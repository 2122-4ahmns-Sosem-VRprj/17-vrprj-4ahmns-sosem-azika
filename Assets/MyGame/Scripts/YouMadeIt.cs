using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class YouMadeIt : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("didCollide");
        SceneManager.LoadSceneAsync("Outro", LoadSceneMode.Single);
    }
}
