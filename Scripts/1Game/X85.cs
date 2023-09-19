using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class X85 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.T) && SceneManager.GetActiveScene().name == "N 85")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
