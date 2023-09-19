using System.Collections;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Serializer : MonoBehaviour
{
    static readonly string GameSave = "ss.json";

    public GameObject player;
    
    void Awake()
    {  
        if (!File.Exists(Path.Combine(Application.persistentDataPath, GameSave)))
        {
            using (FileStream fs = File.Create(Path.Combine(Application.persistentDataPath, GameSave)))
            Debug.Log("file created");
        } 
        
    }
    void Start()
    {
        SaveData data = new SaveData()
        {
            scene = SceneManager.GetActiveScene().name,
            diff = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).diff,
            deathcount = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).deathcount
        };    
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        Debug.Log("Player saved to " + filename);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        File.WriteAllText(filename, json);

    }

}
