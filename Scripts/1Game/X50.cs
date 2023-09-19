using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class X50 : MonoBehaviour
{
    Text TextT;
    float v1;
    float v2;

    void Start()
    {
        TextT = GetComponent<Text>() as Text;
        v1 = PlayerOnCollision.Sec + 4;
        v2 = PlayerOnCollision.Sec + 8;
        TextT.text = v1.ToString() + " - " + v2.ToString();
    }
}
