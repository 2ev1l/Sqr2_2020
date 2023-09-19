using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Msounds3 : MonoBehaviour
{
    public static AudioSource soundData3;
    private GameObject soundPlayer3;
    void Awake()
    {
        if (MMusic.SoundXCheck == 0) 
        {
        soundPlayer3 = GameObject.Find("MainSoundsButton");
        soundData3 = GetComponent<AudioSource>();
        DontDestroyOnLoad(soundPlayer3); 
        DontDestroyOnLoad(soundData3);
        }
    }
}
