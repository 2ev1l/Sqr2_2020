using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMusic : MonoBehaviour
{
    private GameObject musicPlayer;
    AudioSource audioData;
    public static int SoundXCheck;
    void Awake()
    {
        musicPlayer = GameObject.Find("MainMusic");
        DontDestroyOnLoad(musicPlayer); 
        audioData = GetComponent<AudioSource>();
        if (SoundXCheck == 0)
        {
        audioData.Play();
        SoundXCheck += 1;
        }
    }
}

