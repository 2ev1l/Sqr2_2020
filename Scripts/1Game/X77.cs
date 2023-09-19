using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class X77 : MonoBehaviour
{
    void Start()
    {
        Invoke("StopX", 1f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && SceneManager.GetActiveScene().name == "N 77")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.B) && SceneManager.GetActiveScene().name == "N 77 (1)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.O) && SceneManager.GetActiveScene().name == "N 77 (2)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.R) && SceneManager.GetActiveScene().name == "N 77 (3)")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void StopX()
    {
        SceneManager.LoadScene("N 76");
    }
}
