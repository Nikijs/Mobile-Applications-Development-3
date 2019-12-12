using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerJumpSound, music, playerDeathSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerJumpSound = Resources.Load<AudioClip>("jump");
        music = Resources.Load<AudioClip>("music");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(playerJumpSound);
                break;
            case "music":
                audioSrc.PlayOneShot(music);
                break;
        }
    }
}
