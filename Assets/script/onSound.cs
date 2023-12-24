using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class onSound : MonoBehaviour
{

    public AudioSource increaseAudioSource; // 播放增加透明度聲音的 AudioSource
    public AudioClip increaseSound; // 增加透明度的聲音
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayIncreaseSound()
    {
        if (increaseAudioSource != null && increaseSound != null)
        {
            increaseAudioSource.clip = increaseSound;
            increaseAudioSource.Play();
        }
    }
}
