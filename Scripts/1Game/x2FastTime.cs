using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2FastTime : MonoBehaviour
{
    public static bool IsFast;

    void Start()
    {
        IsFast = true;
        Time.timeScale = 1.5f;
    }
}
