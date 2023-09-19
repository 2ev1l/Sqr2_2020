using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectsHideShow : MonoBehaviour
{
    public GameObject Obj1;
    public GameObject Obj2;
    public static GameObject Obj11;
    public static GameObject Obj22;

    void Start()
    {
        Obj11 = Obj1;
        Obj22 = Obj2;
    }
    void Update()
    {
        if (PlayerControl.isGrounded && Input.GetKeyDown(KeyCode.W) && PlayerControl.PauseM.activeSelf == false && PlayerOnCollision.p_isDestroyed == false)
        {
            if (Obj11.activeSelf == false)
            {
                Obj11.SetActive(true);
                Obj22.SetActive(false);
            }
            else
            {
                Obj11.SetActive(false);
                Obj22.SetActive(true);
            }
        }

        if (PlayerControl.isWall && Input.GetKeyDown(KeyCode.W) && PlayerControl.PauseM.activeSelf == false && PlayerOnCollision.p_isDestroyed == false)
        {
            if (Obj11.activeSelf == false)
            {
                Obj11.SetActive(true);
                Obj22.SetActive(false);
            }
            else
            {
                Obj11.SetActive(false);
                Obj22.SetActive(true);
            }
        }
    }
}
