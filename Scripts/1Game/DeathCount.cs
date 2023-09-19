using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DeathCount : MonoBehaviour
{
    static readonly string GameSave = "ss.json";
    public Text deathText;
    int Death;
    
    void Start()
    {
        deathText = GetComponent<Text>() as Text;
        SaveData data = new SaveData(); 
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        Death = copy.deathcount;
        deathText.text = Death.ToString();
    }
}
