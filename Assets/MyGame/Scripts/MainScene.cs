using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
