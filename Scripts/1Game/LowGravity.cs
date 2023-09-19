using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowGravity : MonoBehaviour
{
    void Start()
    {
        Physics2D.gravity = new Vector2(0, -5f);
    }
}
