using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public static Rigidbody2D rigidBody;
    public float moveSpeed;
    bool isFacingRight = true;
    public static bool isGrounded = false;
    public static bool isWall = false;
    public Transform groundCheck;
    public Transform groundCheckScale;
    float groundRadius = 90;
    public LayerMask whatIsGround;
    public LayerMask whatIsWall;
    public GameObject PauseM2;
    public static GameObject PauseM;
    int WallJumpCheck;
    public static float move;
    bool is_col_move;
    public bool is_Inverted;
    float camera1=0.95f;
    float camera2=0.87f;
    float camera3=0.75f;
    float cameraX;
    void Start()
    {
            if (Camera.main.aspect >=1.6807)
            {               
               cameraX=1f;
            }
            if (Camera.main.aspect >=1.3752 && Camera.main.aspect <1.6807)
            {
                cameraX=camera1;
            }
            if (Camera.main.aspect >=1.0697 && Camera.main.aspect <1.3752)
            {
                cameraX=camera2;
            }
            if (Camera.main.aspect <1.0697)
            {
                cameraX=camera3;
            }

        PauseM = PauseM2;
        rigidBody = GetComponent<Rigidbody2D>();
        PlayerOnCollision.p_isDestroyed = false;
    }

    void FixedUpdate()
    {
        if (PlayerOnCollision.p_isDestroyed == false)
        {
            Run();
            isGrounded = Physics2D.OverlapBox(groundCheck.position, groundCheckScale.localScale, groundRadius, whatIsGround);
            isWall = Physics2D.OverlapBox(groundCheck.position, groundCheckScale.localScale, groundRadius, whatIsWall);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "GroundA")
        {
            is_col_move = true;
        }
    }

    void OnCollisionExit2D(Collision2D cole)
    {
        if (cole.gameObject.name == "GroundA")
        {
            is_col_move = false;
        }
    }

    void Run()
    {
        if (PlayerOnCollision.p_isDestroyed == false)
        {
            if (is_col_move == false)
            {
                if (is_Inverted)
                {
                    move = Input.GetAxis("Horizontal") * -1f*cameraX;
                }
                else
                {
                    move = Input.GetAxis("Horizontal")*cameraX;
                }
            }
            
            if (is_col_move == true)
            {
                if (isGrounded == true)
                {
                    if (is_Inverted)
                    {
                        move = Input.GetAxis("Horizontal") * -1*cameraX;
                    }
                    else
                    {
                        move = Input.GetAxis("Horizontal")*cameraX;
                    }
                }

                if (isGrounded == false)
                {
                    if (is_Inverted)
                    {
                        move = Input.GetAxis("Horizontal") * -0.05f*cameraX;
                    }
                    else
                    {
                        move = Input.GetAxis("Horizontal") * 0.05f*cameraX;
                    }
                }
            }
            rigidBody.velocity = new Vector2(move * (moveSpeed - 5), rigidBody.velocity.y);
            if (move > 0 && !isFacingRight)
            {
            Flip();
            }
            else if (move < 0 && isFacingRight)
            {
            Flip();
            }
            
        }
    }
    
    void Flip()
    {
        if (PlayerOnCollision.p_isDestroyed == false)
        {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        }
    }

    void Update()
    {
        if (PlayerOnCollision.p_isDestroyed == false)
        {
            if (isGrounded && Input.GetKeyDown(KeyCode.W) && PauseM.activeSelf == false)
            {
                if (isWall)
                {
                    rigidBody.AddForce(new Vector2(0, 1800f)*cameraX);
                    Msounds.soundData.Play();
                }
                else
                {
                    rigidBody.AddForce(new Vector2(0, 1800f)*cameraX);
                    Msounds.soundData.Play();
                }
            }

            if (rigidBody.velocity.y > 47)
            {
                rigidBody.AddForce(new Vector2(0, -800f)*cameraX);
                Debug.Log("FORCE > 47");
            }

            if (Input.GetKeyDown(KeyCode.R) && PauseM.activeSelf == false)
            {
                Invoke("RestartTime", 1);
            }
            
            if (isWall && Input.GetKeyDown(KeyCode.W) && PauseM.activeSelf == false && WallJumpCheck == 0 && !isGrounded)
            {
                {
                if (rigidBody.velocity.y < 40 && rigidBody.velocity.y > 30)
                {
                rigidBody.AddForce(new Vector2(0, 500f)*cameraX);
                }
                if (rigidBody.velocity.y < 30 && rigidBody.velocity.y > 20)
                {
                rigidBody.AddForce(new Vector2(0, 670f)*cameraX);
                }
                // -100
                if (rigidBody.velocity.y < 20 && rigidBody.velocity.y > 10)
                {
                rigidBody.AddForce(new Vector2(0, 850f)*cameraX);
                }
                if (rigidBody.velocity.y < 10 && rigidBody.velocity.y > 0)
                {
                rigidBody.AddForce(new Vector2(0, 1200f)*cameraX);
                }
                if (rigidBody.velocity.y < 0 && rigidBody.velocity.y > -5)
                {
                rigidBody.AddForce(new Vector2(0, 1600f)*cameraX);
                }
                // -200
                if (rigidBody.velocity.y < -5 && rigidBody.velocity.y > -10)
                {
                rigidBody.AddForce(new Vector2(0, 1800f)*cameraX);
                }
                // -300
                if (rigidBody.velocity.y < -10 && rigidBody.velocity.y > -15)
                {
                rigidBody.AddForce(new Vector2(0, 1900f)*cameraX);
                }
                if (rigidBody.velocity.y < -15 && rigidBody.velocity.y > -20)
                {
                rigidBody.AddForce(new Vector2(0, 2300f)*cameraX);
                }
                // -500
                if (rigidBody.velocity.y < -20 && rigidBody.velocity.y > -25)
                {
                rigidBody.AddForce(new Vector2(0, 2400f)*cameraX);
                }
                // -700
                if (rigidBody.velocity.y < -25 && rigidBody.velocity.y > -28)
                {
                rigidBody.AddForce(new Vector2(0, 2550f)*cameraX);
                }
                // -800
                if (rigidBody.velocity.y < -28 && rigidBody.velocity.y > -31)
                {
                rigidBody.AddForce(new Vector2(0, 2700f)*cameraX);
                }
                if (rigidBody.velocity.y < -31 && rigidBody.velocity.y > -34)
                {
                rigidBody.AddForce(new Vector2(0, 3050f)*cameraX);
                }
                // -1000
                if (rigidBody.velocity.y < -34 && rigidBody.velocity.y > -37)
                {
                rigidBody.AddForce(new Vector2(0, 3200f)*cameraX);
                }
                if (rigidBody.velocity.y < -37 && rigidBody.velocity.y > -40)
                {
                rigidBody.AddForce(new Vector2(0, 3400f)*cameraX);
                }
                if (rigidBody.velocity.y < -40 && rigidBody.velocity.y > -43)
                {
                rigidBody.AddForce(new Vector2(0, 3400f)*cameraX);
                }
                if (rigidBody.velocity.y < -43 && rigidBody.velocity.y > -46)
                {
                rigidBody.AddForce(new Vector2(0, 3600f)*cameraX);
                }
                if (rigidBody.velocity.y < -46 && rigidBody.velocity.y > -49)
                {
                rigidBody.AddForce(new Vector2(0, 3750f)*cameraX);
                }
                if (rigidBody.velocity.y < -49 && rigidBody.velocity.y > -52)
                {
                rigidBody.AddForce(new Vector2(0, 3900f)*cameraX);
                }
                if (rigidBody.velocity.y < -52)
                {
                rigidBody.AddForce(new Vector2(0, 4100f)*cameraX);
                }
                Msounds.soundData.Play();
                WallJumpCheck = 1;
                }
            }

            if (!isWall)
            {
                WallJumpCheck = 0;
            }
        }
    }

    void RestartTime()
    {
        if (PlayerOnCollision.p_isDestroyed == false)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

}