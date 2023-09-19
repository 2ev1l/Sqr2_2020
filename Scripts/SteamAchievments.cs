using System;
using UnityEngine;
using System.Collections;
using System.Linq;
using Steamworks;
using UnityEngine.SceneManagement;
using System.IO;

public class SteamAchievments : MonoBehaviour 
{
    static readonly string GameSave = "ss.json";
    
    void Start()
    {
        if (MMusic.SoundXCheck < 3)
        {
        DontDestroyOnLoad( gameObject );
        MMusic.SoundXCheck += 1;
        }
    }

        private void OnApplicationQuit() {
        if(SteamManager.Initialized)
        SteamAPI.Shutdown();
        }

    private void Update()
    {
        SaveData data = new SaveData()
            {
                diff = JsonUtility.FromJson<SaveData>(File.ReadAllText(Path.Combine(Application.persistentDataPath, GameSave))).diff,
            };
            string json = JsonUtility.ToJson(data);
            string filename = Path.Combine(Application.persistentDataPath, GameSave);
            string jsonFromFile = File.ReadAllText(filename);
            SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);

        Scene scene = SceneManager.GetActiveScene();
        
        if(SteamManager.Initialized)
        {
        if (scene.name == "Bonus1") {
        Steamworks.SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_SEC1");
        SteamUserStats.StoreStats();
        }

        if (scene.name == "Secret 2") {
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_SEC2");
        SteamUserStats.StoreStats();
        }
        if (scene.name == "Sec 3"){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_SEC3");
        SteamUserStats.StoreStats();
        }
        if (scene.name == "Tutorial F") {
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_T");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 1")
        if (copy.diff==2){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_1");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 4") 
        if (copy.diff==2){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_4");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 8") 
        if (copy.diff==2){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_8");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 16") 
        if (copy.diff==2){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_16");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 32") 
        if (copy.diff==2){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_32");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 64") 
        if (copy.diff==2){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_64");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 100")
        if (copy.diff==2){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_100");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 8") 
        if (copy.diff==3){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_8H");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 16") 
        if (copy.diff==3){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_16H");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 32")
        if (copy.diff==3){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_32H");
SteamUserStats.StoreStats();
        }
        if (scene.name == "N 64")
        if (copy.diff==3){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_64H");
        SteamUserStats.StoreStats();
        }
        if (scene.name == "N 100")
        if (copy.diff==3){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_100H");
SteamUserStats.StoreStats();
        }
        if (scene.name == "Final")
        if (copy.diff==3)
        if (X102.RankTotal == "SS"){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_SSH");
        SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_SH");
        SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_AH");
        SteamUserStats.StoreStats();
        }

        if (scene.name == "Final") 
        if (copy.diff==3)
        if (X102.RankTotal == "S")
        {
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_SH");
        SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_AH");
        SteamUserStats.StoreStats();
        }

        if (scene.name == "Final") 
        if (copy.diff==3)
        if (X102.RankTotal == "A") {
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_AH");
        SteamUserStats.StoreStats();
        }
        if (scene.name == "Final") 
        if (copy.diff==2)
        if (X102.RankTotal == "SS"){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_SS");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_S");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_A");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_B");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_C");SteamUserStats.StoreStats();
        }

        if (scene.name == "Final") 
        if (copy.diff==2)
        if (X102.RankTotal == "S"){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_S");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_A");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_B");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_C");SteamUserStats.StoreStats();
        }

        if (scene.name == "Final") 
        if (copy.diff==2)
        if (X102.RankTotal == "A"){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_A");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_B");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_C");SteamUserStats.StoreStats();
        }

        if (scene.name == "Final") 
        if (copy.diff==2)
        if (X102.RankTotal == "B"){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_B");SteamUserStats.StoreStats();
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_C");SteamUserStats.StoreStats();
        }

        if (scene.name == "Final") 
        if (copy.diff==2)
        if (X102.RankTotal == "C"){
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_C");
        SteamUserStats.StoreStats();
	}

        if (scene.name == "Final") {
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_1_GG");
        SteamUserStats.StoreStats();
	}
        }
    }
}