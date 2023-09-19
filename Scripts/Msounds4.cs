using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Msounds4 : MonoBehaviour
{
    public static AudioSource soundData4;
    private GameObject soundPlayer4;
    void Awake()
    {
        if (MMusic.SoundXCheck == 0) 
        {
        soundPlayer4 = GameObject.Find("MainSoundsButton2");
        soundData4 = GetComponent<AudioSource>();
        DontDestroyOnLoad(soundPlayer4); 
        DontDestroyOnLoad(soundData4);
        }
    }
}
