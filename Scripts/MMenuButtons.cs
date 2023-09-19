using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using Steamworks;

public class MMenuButtons : MonoBehaviour
{   
    static readonly string GameSave = "ss.json";
    static readonly string TimerSave = "timer.json";
    public static bool is_FS;

    IEnumerator TutorialStartAsync() 
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Tutorial");
        if (asyncLoad.progress == 1f) 
            {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Tutorial"));
            yield return null;
            }   
    }      

    public void TutorialStart()
    {
        StartCoroutine("TutorialStartAsync");
    }
//
    IEnumerator EasyStartAsync() 
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("N 1");
        if (asyncLoad.progress == 1f) 
            {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("N 1"));
            yield return null;
            }   
    }      

    public void EasyStart()
    {
        SaveData data = new SaveData()
        {
            deathcount = 0,
            diff = 1
        };
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        File.WriteAllText(filename, json);
        StartCoroutine("EasyStartAsync");
    }
//
    IEnumerator NormalStartAsync() 
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("N 1");
        if (asyncLoad.progress == 1f) 
            {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("N 1"));
            yield return null;
            }   
    }      

    public void NormalStart()
    {   
        SaveData data = new SaveData()
        {
            diff = 2,
            deathcount = 0
        };
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        File.WriteAllText(filename, json);
        StartCoroutine("NormalStartAsync");
    }
//
    IEnumerator HardcoreStartAsync() 
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("N 1");
        if (asyncLoad.progress == 1f) 
            {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("N 1"));
            yield return null;
            }   
    }      

    public void HardcoreStart()
    {
        SaveData data = new SaveData()
        {
            diff = 3,
            deathcount = 0
        };
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        File.WriteAllText(filename, json);
        StartCoroutine("HardcoreStartAsync");
    }
//
    public void ExitPressed()
    {
        Physics2D.gravity = new Vector2(0, -15.2f);
        C2.pcheck = 0;
        SteamAPI.Shutdown();
        Application.Quit();
        SteamAPI.Shutdown();
    }

    public void MenuPressed()
        {
            SceneManager.LoadScene("Menu");
            Physics2D.gravity = new Vector2(0, -15.2f);
            Time.timeScale = 1f;
            C2.pcheck = 0;
        }
        
    public void LoadPressed()
    {   
        SaveData data = new SaveData();
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        SceneManager.LoadScene(copy.scene);
    }

    public void ButtonSoundPressed()
    {
        Msounds3.soundData3.Play();
    }
    
    public void FS()
    {
        is_FS = !is_FS;
        Screen.fullScreen = is_FS;
    }

    public void TimerRestart()
    {
        SaveDatan2 data = new SaveDatan2()
        {
            TimerTime = 0
        };
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, TimerSave);
        File.WriteAllText(filename, json);
    }

    void Start()
    {
        is_FS = true;
    }
}



