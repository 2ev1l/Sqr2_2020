using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Msounds2 : MonoBehaviour
{
    public static AudioSource soundData2;
    private GameObject soundPlayer2;
    void Awake()
    {
        if (MMusic.SoundXCheck < 2)
        {
        soundPlayer2 = GameObject.Find("MainSoundsDeath");
        soundData2 = GetComponent<AudioSource>();
        DontDestroyOnLoad(soundPlayer2); 
        DontDestroyOnLoad(soundData2);
        MMusic.SoundXCheck += 1;
        }
    }
}
