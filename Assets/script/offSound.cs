using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class offSound : MonoBehaviour
{
    public AudioSource decreaseAudioSource; // 播放增加透明度聲音的 AudioSource
    public AudioClip decreaseSound; // 增加透明度的聲音
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayDecreaseSound()
    {
        if (decreaseAudioSource != null && decreaseSound != null)
        {
            decreaseAudioSource.clip = decreaseSound;
            decreaseAudioSource.Play();
        }
    }
}
