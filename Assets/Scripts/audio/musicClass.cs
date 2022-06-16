using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}


/*Attach your audio source to this object.

From scenes, where you want to play music, call method:

 GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
From scenes, where you don't want to play music, call method:

 GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();*/
