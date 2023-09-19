using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Msounds : MonoBehaviour
{
    public static AudioSource soundData;
    private GameObject soundPlayer;
    void Awake()
    {
        if (MMusic.SoundXCheck == 0) 
        {
        soundPlayer = GameObject.Find("MainSoundsJump");
        soundData = GetComponent<AudioSource>();
        DontDestroyOnLoad(soundPlayer); 
        DontDestroyOnLoad(soundData);
        }
    }
}

