using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C2 : MonoBehaviour
{
    public GameObject MenuScene;
    public static int pcheck;
    public static bool CheckSTD;

	void Update () 
    {
		if (Input.GetKeyDown(KeyCode.Escape) && pcheck == 0)
        { 
            Invoke("MenuActive", 0.5f);
		}					
	}

    public void ConinueGame()
    {
        MenuScene.SetActive(false); 
        if (x2SlowTime.IsSlow == true)
        {
            Time.timeScale = 0.5f;
        }
        else
        {
            if (x2FastTime.IsFast == true)
            {
                Time.timeScale = 1.5f;
            }
            else
            {
            Time.timeScale = 1f; 
            }
        }
        pcheck = 0;
    }

    void MenuActive()
    {
        if (PlayerOnCollision.p_isDestroyed == false)
        {
        MenuScene.SetActive(true);
        Time.timeScale = 0f;
        pcheck = 1;
        }
    }

    public void Prev2LevelLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        Physics2D.gravity = new Vector2(0, -15.2f);
        Time.timeScale = 1f;
    }

    public void Prev3LevelLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        Physics2D.gravity = new Vector2(0, -15.2f);
        Time.timeScale = 1f;
    }

    public void NextLevelLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Physics2D.gravity = new Vector2(0, -15.2f);
        Time.timeScale = 1f;
    }

    public void NextLevelLoadCollision()
    {
        if (CheckSTD == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            Time.timeScale = 1f;
            CheckSTD = false;
        }
    }
    
    public void SecretLoad()
    {
        SceneManager.LoadScene("Secret 2");
        Physics2D.gravity = new Vector2(0, -15.2f);
        Time.timeScale = 1f;
    }
}


