using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2SlowTime : MonoBehaviour
{
    public static bool IsSlow;

    void Start()
    {
        IsSlow = true;
        Time.timeScale = 0.5f;
    }
}
