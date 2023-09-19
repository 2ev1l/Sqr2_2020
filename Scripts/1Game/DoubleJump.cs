using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
   
    public static int JumpCounter;

    void Start()
    {
        
        JumpCounter = 0;
    }

    void Update()
    {
        if (PlayerControl.isGrounded == false && Input.GetKeyDown(KeyCode.W) && JumpCounter == 0 && PlayerControl.PauseM.activeSelf == false)
        {
            if (PlayerControl.rigidBody.velocity.y < 40 && PlayerControl.rigidBody.velocity.y > 30)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 500f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < 30 && PlayerControl.rigidBody.velocity.y > 20)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 670f));
                JumpCounter += 1;
            }
            // -100
            if (PlayerControl.rigidBody.velocity.y < 20 && PlayerControl.rigidBody.velocity.y > 10)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 850f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < 10 && PlayerControl.rigidBody.velocity.y > 0)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 1200f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < 0 && PlayerControl.rigidBody.velocity.y > -5)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 1600f));
                JumpCounter += 1;
            }
            // -200
            if (PlayerControl.rigidBody.velocity.y < -5 && PlayerControl.rigidBody.velocity.y > -10)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 1800f));
                JumpCounter += 1;
            }
            // -300
            if (PlayerControl.rigidBody.velocity.y < -10 && PlayerControl.rigidBody.velocity.y > -15)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 1900f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -15 && PlayerControl.rigidBody.velocity.y > -20)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 2300f));
                JumpCounter += 1;
            }
            // -500
            if (PlayerControl.rigidBody.velocity.y < -20 && PlayerControl.rigidBody.velocity.y > -25)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 2400f));
                JumpCounter += 1;
            }
            // -700
            if (PlayerControl.rigidBody.velocity.y < -25 && PlayerControl.rigidBody.velocity.y > -28)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 2550f));
                JumpCounter += 1;
            }
            // -800
            if (PlayerControl.rigidBody.velocity.y < -28 && PlayerControl.rigidBody.velocity.y > -31)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 2700f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -31 && PlayerControl.rigidBody.velocity.y > -34)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 3050f));
                JumpCounter += 1;
            }
            // -1000
            if (PlayerControl.rigidBody.velocity.y < -34 && PlayerControl.rigidBody.velocity.y > -37)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 3200f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -37 && PlayerControl.rigidBody.velocity.y > -40)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 3400f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -40 && PlayerControl.rigidBody.velocity.y > -43)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 3400f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -43 && PlayerControl.rigidBody.velocity.y > -46)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 3600f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -46 && PlayerControl.rigidBody.velocity.y > -49)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 3750f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -49 && PlayerControl.rigidBody.velocity.y > -52)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 3900f));
                JumpCounter += 1;
            }
            if (PlayerControl.rigidBody.velocity.y < -52)
            {
                PlayerControl.rigidBody.AddForce(new Vector2(0, 4100f));
                JumpCounter += 1;
            }
            Msounds.soundData.Play();

            if (GameObjectsHideShow.Obj11.activeSelf == false)
            {
                GameObjectsHideShow.Obj11.SetActive(true);
                GameObjectsHideShow.Obj22.SetActive(false);
            }
            else
            {
                GameObjectsHideShow.Obj11.SetActive(false);
                GameObjectsHideShow.Obj22.SetActive(true);
            }
        }

        if (PlayerControl.isGrounded == true && JumpCounter == 1)
        {
            JumpCounter = 0;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("GroundCheck = " + PlayerControl.isGrounded + ". JumpCounter = " + JumpCounter);
        }
    }
}
