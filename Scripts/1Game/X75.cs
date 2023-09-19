using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class X75 : MonoBehaviour
{
    void Start()
    {
        Invoke("AAB", 4f);
    }

    void AAB()
    {
        if (PlayerControl.rigidBody.velocity.magnitude == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
