using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class X102 : MonoBehaviour
{
    static readonly string GameSave = "ss.json";
    static readonly string TimerSave = "timer.json";
    public Text TimeText;
    public Text DeathText;
    public Text TotalText;
    public static string RankDeath;
    public static string RankTime;
    public static string RankTotal;
    void Start()
    {
        SaveData data = new SaveData();
        string json = JsonUtility.ToJson(data);
        string filename = Path.Combine(Application.persistentDataPath, GameSave);
        string jsonFromFile = File.ReadAllText(filename);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);

        SaveDatan2 data2 = new SaveDatan2();
        string json2 = JsonUtility.ToJson(data2);
        string filename2 = Path.Combine(Application.persistentDataPath, TimerSave);
        string jsonFromFile2 = File.ReadAllText(filename2);
        SaveDatan2 copy2 = JsonUtility.FromJson<SaveDatan2>(jsonFromFile2);

        if (copy.deathcount < 300)
        {
            if (copy.deathcount < 200)
            {
                if (copy.deathcount < 150)
                {
                    if (copy.deathcount < 100)
                    {
                        if (copy.deathcount < 50)
                        {
                            if (copy.deathcount < 25)
                            {
                                if (copy.deathcount < 10)
                                {
                                    if (copy.deathcount == 0)
                                    {
                                        RankDeath = "SS";
                                    }
                                    else
                                    {
                                        RankDeath = "S";
                                    }
                                }
                                else
                                {
                                    RankDeath = "A";
                                }
                            }
                            else
                            {
                                RankDeath = "A";
                            }
                        }
                        else
                        {
                            RankDeath = "B";
                        }
                    }
                    else
                    {
                        RankDeath = "C";
                    }
                }
                else
                {
                    RankDeath = "D";
                }
            }
            else
            {
                RankDeath = "E";
            }
        } 
        else
        {
            RankDeath = "F";
        }

        if (copy2.TimerTime < 10800 && copy.deathcount < 300)
        {
            if (copy2.TimerTime < 9000 && copy.deathcount < 200)
            {
                if (copy2.TimerTime < 7200 && copy.deathcount < 150)
                {
                    if (copy2.TimerTime < 5400 && copy.deathcount < 100)
                    {
                        if (copy2.TimerTime < 3600 && copy.deathcount < 50)
                        {
                            if (copy2.TimerTime < 2400 && copy.deathcount < 25)
                            {
                                if (copy2.TimerTime < 1500 && copy.deathcount < 10)
                                {
                                    if (copy2.TimerTime < 900 && copy.deathcount == 0)
                                    {
                                        RankTotal = "SS";
                                    }
                                    else
                                    {
                                        RankTotal = "S";
                                    }
                                }
                                else
                                {
                                    RankTotal = "A";
                                }
                            }
                            else
                            {
                                RankTotal = "A";
                            }
                        }
                        else
                        {
                            RankTotal = "B";
                        }
                    }
                    else
                    {
                        RankTotal = "C";
                    }
                }
                else
                {
                    RankTotal = "D";
                }
            }
            else
            {
                RankTotal = "E";
            }
        } 
        else
        {
            RankTotal = "F";
        }

        if (copy2.TimerTime < 10800)
        {
            if (copy2.TimerTime < 9000)
            {
                if (copy2.TimerTime < 7200)
                {
                    if (copy2.TimerTime < 5400)
                    {
                        if (copy2.TimerTime < 3600)
                        {
                            if (copy2.TimerTime < 2400)
                            {
                                if (copy2.TimerTime < 1500)
                                {
                                    if (copy2.TimerTime < 900)
                                    {
                                        RankTime = "SS";
                                    }
                                    else
                                    {
                                        RankTime = "S";
                                    }
                                }
                                else
                                {
                                    RankTime = "A";
                                }
                            }
                            else
                            {
                                RankTime = "A";
                            }
                        }
                        else
                        {
                            RankTime = "B";
                        }
                    }
                    else
                    {
                        RankTime = "C";
                    }
                }
                else
                {
                    RankTime = "D";
                }
            }
            else
            {
                RankTime = "E";
            }
        } 
        else
        {
            RankTime = "F";
        }

        TimeText.text = "Time: " + copy2.TimerText + ". Rank: " + RankTime;
        DeathText.text = "Death: " + copy.deathcount.ToString() + ". Rank: " + RankDeath;
        TotalText.text = "Total Rank: " + RankTotal;
    }
}
