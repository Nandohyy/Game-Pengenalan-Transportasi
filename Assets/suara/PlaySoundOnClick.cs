using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip soundClip;
    private AudioSource soundSource;
    

    void Start() 
    {
        soundSource = GetComponent<AudioSource>();
        soundSource.clip = soundClip;

    }

    void OnMouseDown()
    {
        soundSource.Play();

    }
    
}
