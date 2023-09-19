using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity1 : MonoBehaviour
{
    void Start()
    {
        Physics2D.gravity = new Vector2(0, 15.2f);
    }
}
