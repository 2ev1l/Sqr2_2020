using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class HidePanel : MonoBehaviour
{
    static readonly string GameSave = "ss.json";
    public GameObject ToHide;
    void Start()
    {
        SaveData data = new SaveData();
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        if (copy.diff == 3)
        {
            ToHide.SetActive(false);
        }
    }
}
