using System.Collections;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text counterText;
    public float seconds, minutes, hours;
    static readonly string TimerSave = "timer.json";
    public GameObject TimerX;
    public static int counttime;

    void Awake()
    {  
        if (!File.Exists(Path.Combine(Application.persistentDataPath, TimerSave)))
        {
            using (FileStream fs = File.Create(Path.Combine(Application.persistentDataPath, TimerSave)))
            Debug.Log("file created");
        } 
    }

    void Start()
    {
        InvokeRepeating("CountStart", 0, 1);
    }

    void FixedUpdate()
    {
        counterText = GetComponent<Text>() as Text;

        SaveDatan2 data = new SaveDatan2()
        {
            TimerText = minutes.ToString("00") + ":" + seconds.ToString("00"),
            TimerTime = JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime
        };    
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, TimerSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveDatan2 copy = JsonUtility.FromJson<SaveDatan2>(jsonFromFile);
        File.WriteAllText(filename, json);

        if (TimerX.activeSelf == true)
        {
        float t = copy.TimerTime;
        minutes = (int)(t/60f);
        seconds = (int)(t % 60f);
        counterText.text = copy.TimerText;
        }
    }

    void CountStart()
    {
        SaveDatan2 data = new SaveDatan2()
        {
            TimerText = JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerText,
            TimerTime = JsonUtility.FromJson<SaveDatan2>(File.ReadAllText(Path.Combine(Application.persistentDataPath, TimerSave))).TimerTime + counttime
        };
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, TimerSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveDatan2 copy = JsonUtility.FromJson<SaveDatan2>(jsonFromFile);
        File.WriteAllText(filename, json);
        counttime = 1;
    }
}
