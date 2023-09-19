using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class PlayerOnCollision : MonoBehaviour
{
    static readonly string GameSave = "ss.json";
    static readonly string TimerSave = "timer.json";
    GameObject PlayerCol;
    public static bool p_isDestroyed;
    int deathcountC;
    int deathcountB;
    public static float Sec;

    void Start()
    {
        p_isDestroyed = false;
        Sec = JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "LOADNEXTLEVEL")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            C2.CheckSTD = false;
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
        }
        if (col.gameObject.name == "LOADNEXTLEVEL-1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
        }
        if (col.gameObject.name == "LOADNEXTLEVEL-2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
        }
        if (col.gameObject.name == "LOADCURRENTLEVEL")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            Physics2D.gravity = new Vector2(0, -15.2f);
            C2.CheckSTD = false;
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
        }
        if (col.gameObject.name == "LOADBONUS1")
        {
            SceneManager.LoadScene("Bonus1");
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
        }
        if (col.gameObject.name == "LOADFROMBONUS1")
        {
            SceneManager.LoadScene("N 28");
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
        }
        if (col.gameObject.name == "LOADNEXTON%2")
        {
            if (JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime % 2 == 0)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
        }
        if (col.gameObject.name == "LOADNEXTON%3")
        {
            if (JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime % 2 == 1)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
        }
        if (col.gameObject.name == "LOADNEXTONSEC8")
        {
            if (Sec + 9 > JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
        }
        if (col.gameObject.name == "LOADNEXTAFTERSEC16")
        {
            if (Sec + 16 < JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
        }
        if (col.gameObject.name == "LOADNEXTAFTERSEC4x8")
        {
            if (Sec + 4 < JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime && Sec + 9 > JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Physics2D.gravity = new Vector2(0, -15.2f);
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
        }
        if (col.gameObject.name == "spikesT")
        {   
            deathcountC = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).deathcount;
            deathcountC += 1;
            C2.CheckSTD = false;
            x2SlowTime.IsSlow = false;
            x2FastTime.IsFast = false;
            Time.timeScale = 1f;
            
            SaveData data = new SaveData()
            {
                scene = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).scene,
                diff = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).diff,
                deathcount = deathcountC
            };
            string json = JsonUtility.ToJson(data);
            string filename = Path.Combine(Application.persistentDataPath, GameSave);
            string jsonFromFile = File.ReadAllText(filename);
            SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
            File.WriteAllText(filename, json);

            Destroy(GetComponent<Rigidbody2D>());
            p_isDestroyed = true;
            GetComponent<SpriteRenderer>().color = new Color (0, 0, 0, 0);
            GetComponentInParent<SpriteRenderer>().color = new Color (1, 1, 1, 0);
            InvokeRepeating("Transform", 0f, 0.001f);
            Msounds2.soundData2.Play();
            Invoke("RestartS", 0.6f);
        }
        if (col.gameObject.name == "spikesTN")
        {
            Destroy(GetComponent<Rigidbody2D>());
            p_isDestroyed = true;
            GetComponent<SpriteRenderer>().color = new Color (0, 0, 0, 0);
            GetComponentInParent<SpriteRenderer>().color = new Color (1, 1, 1, 0);
            InvokeRepeating("Transform", 0f, 0.001f);
            Msounds2.soundData2.Play();
            Invoke("RestartSN", 0.6f);
        }
        if (col.gameObject.name == "spikesTH")
        {
            Destroy(GetComponent<Rigidbody2D>());
            p_isDestroyed = true;
            GetComponent<SpriteRenderer>().color = new Color (0, 0, 0, 0);
            GetComponentInParent<SpriteRenderer>().color = new Color (1, 1, 1, 0);
            InvokeRepeating("Transform", 0f, 0.001f);
            Msounds2.soundData2.Play();
            Invoke("RestartSH", 0.6f);
        }
        if (col.gameObject.name == "spikesG")
        {   
            deathcountC = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).deathcount;
            deathcountC += 1;
            C2.CheckSTD = false;
            SaveData data = new SaveData()
            {
                scene = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).scene,
                diff = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).diff,
                deathcount = deathcountC
            };
            string json = JsonUtility.ToJson(data);
            string filename = Path.Combine(Application.persistentDataPath, GameSave);
            string jsonFromFile = File.ReadAllText(filename);
            SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
            File.WriteAllText(filename, json);
            
            if (copy.diff == 1)
            {
                Destroy(GetComponent<Rigidbody2D>());
                p_isDestroyed = true;
                GetComponent<SpriteRenderer>().color = new Color (0, 0, 0, 0);
                GetComponentInParent<SpriteRenderer>().color = new Color (1, 1, 1, 0);
                InvokeRepeating("Transform", 0f, 0.001f);
                Msounds2.soundData2.Play();
                Invoke("RestartS", 0.6f);
            }
            
            if (copy.diff == 2)
            {
                Destroy(GetComponent<Rigidbody2D>());
                p_isDestroyed = true;
                GetComponent<SpriteRenderer>().color = new Color (0, 0, 0, 0);
                GetComponentInParent<SpriteRenderer>().color = new Color (1, 1, 1, 0);
                InvokeRepeating("Transform", 0f, 0.001f);
                Msounds2.soundData2.Play();
                Physics2D.gravity = new Vector2(0, -15.2f);
                Invoke("RestartSN", 0.6f);
            }

            if (copy.diff == 3)
            {
                SaveData data2 = new SaveData()
                {
                    scene = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).scene,
                    diff = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).diff,
                    deathcount = 0
                };
                File.WriteAllText(Path.Combine(Application.persistentDataPath, GameSave), JsonUtility.ToJson(data2));

                Destroy(GetComponent<Rigidbody2D>());
                p_isDestroyed = true;
                GetComponent<SpriteRenderer>().color = new Color (0, 0, 0, 0);
                GetComponentInParent<SpriteRenderer>().color = new Color (1, 1, 1, 0);
                InvokeRepeating("Transform", 0f, 0.001f);
                Msounds2.soundData2.Play();
                Physics2D.gravity = new Vector2(0, -15.2f);
                Invoke("RestartSHG", 0.6f);
            }
        }
        if (col.gameObject.name == "menuloadp")
        {
            SceneManager.LoadScene("Menu");
        }

        if (col.gameObject.name == "GroundA")
        {
            InvokeRepeating("StopCol", 0, 0.001f);
        }
        if (col.gameObject.name == "STD")
        {
            C2.CheckSTD = true;
        }
        if (col.gameObject.name == "STDEXIT")
        {
            C2.CheckSTD = false;
        }
    }

    void OnCollisionExit2D(Collision2D cole)
    {
        if (cole.gameObject.name == "GroundA")
        {
            Invoke("StopStop", 1f);
        }

        if (cole.gameObject.name == "STD")
        {
            C2.CheckSTD = false;
        }
    }

    void RestartS()
    {   
        if (SceneManager.GetActiveScene().name == "N 21")
        {
            deathcountB = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).deathcount;
            if (deathcountB < 21)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - deathcountB);
            }
            else
            {
                SceneManager.LoadScene("N 1");
            }
        }
        else
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
        x2SlowTime.IsSlow = false;
        x2FastTime.IsFast = false;
        Time.timeScale = 1f;
    }

    void RestartSN()
    {
        if (SceneManager.GetActiveScene().name == "N 21")
        {
            deathcountB = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).deathcount;
            if (deathcountB < 21)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - deathcountB);
            }
            else
            {
                SceneManager.LoadScene("N 1");
            }
        }
        else
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        x2SlowTime.IsSlow = false;
        x2FastTime.IsFast = false;
        Time.timeScale = 1f;
    }

    void RestartSH()
    {
        SceneManager.LoadScene("Tutorial");
    }

    void RestartSHG()
    {
        SceneManager.LoadScene("N 1");
        x2SlowTime.IsSlow = false;
        x2FastTime.IsFast = false;
        Time.timeScale = 1f;
    }

    void StopCol()
    {
        PlayerControl.move *= 0.05f;

    }

    void StopStop()
    {
        CancelInvoke("StopCol");
    }
    
    void Transform()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(-0.5f, -0.5f, -0.5f), 0.05f);
    }
}
