using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XSecret : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKey(KeyCode.Alpha6) && Input.GetKey(KeyCode.Alpha3) && Input.GetKey(KeyCode.Alpha4) && Input.GetKey(KeyCode.Alpha2) && SceneManager.GetActiveScene().name == "Secret 2")
        {
            SceneManager.LoadScene("Sec 3");
        }
    }
}
