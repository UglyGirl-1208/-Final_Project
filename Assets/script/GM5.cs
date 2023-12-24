using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GM5 : MonoBehaviour
{
    private string sequence = ""; // 初始化按鈕序列
    private string correctSequence = "開燈關燈開燈開燈關燈開燈關燈開燈關燈開燈關燈開燈開燈關燈關燈開燈關燈開燈關燈關燈關燈關燈"; // 正確的按鈕順序
    public TMP_Text errorMessage; // 設定錯誤提示的 Text 元素
    public TMP_Text successMessage; // 設定成功提示的 Text 元素
    public GameObject[] buttons; // 按鈕的 GameObject 陣列
    public string nextSceneName = "final"; // 下一個場景的名稱
    private bool canLoadNextScene = false; // 控制是否可以載入下一個場景
    public string backSceneName = "Q1_1"; //回到一開始的場景名稱
    private bool canLoadBackScene = false; //控制是否可以載入上一個場景

    public AudioClip correctSound; // 正確音效
    public AudioClip wrongSound; // 錯誤音效
    private AudioSource audioSource; // AudioSource 元件
    // Start is called before the first frame update
    void Start()
    {
        errorMessage.gameObject.SetActive(false);
        // 隱藏成功提示
            successMessage.gameObject.SetActive(false);
         // 顯示按鈕
            ShowButtons();
        // 獲取 AudioSource 元件
        audioSource = GetComponent<AudioSource>();
        // 關閉一開始的聲音
        audioSource.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        //檢測按下空白鍵
        if (Input.GetKeyDown(KeyCode.Space) && canLoadBackScene)
        {
            // 載入下一個場景
            SceneManager.LoadScene(backSceneName);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canLoadNextScene)
        {
            // 載入下一個場景
            SceneManager.LoadScene(nextSceneName);
        }
    }

    public void OnButtonPressed(GameObject button)
    {
        // 將按鈕的名稱添加到序列中
        sequence += button.name;

        // 檢查按鈕序列是否與正確序列匹配
        if (sequence.Length > correctSequence.Length || sequence != correctSequence.Substring(0, sequence.Length))
        {
            // 如果按錯了，提示並清空序列
            Debug.Log("按錯了！重新開始...");
            sequence = "";

            // 顯示錯誤提示
            errorMessage.gameObject.SetActive(true);
            // 隱藏按鈕
            HideButtons();
            canLoadBackScene = true;
             PlaySound(wrongSound);
        }
        else if (sequence == correctSequence)
        {
            // 如果按對了，觸發相應的事件或進入下一關
            Debug.Log("恭喜通過關卡！");
            // 顯示成功提示
            successMessage.gameObject.SetActive(true);
            // 隱藏按鈕
            HideButtons();
            // 在這裡可以觸發通過關卡的事件
            canLoadNextScene = true;
            PlaySound(correctSound);
        }
    }

    private void HideButtons()
    {
        // 隱藏所有按鈕
        foreach (GameObject button in buttons)
        {
            button.SetActive(false);
        }
    }

    private void ShowButtons()
    {
        // 顯示所有按鈕
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }

     void PlaySound(AudioClip clip)
    {
        // 如果這裡的 audioSource 是 GameManager 內的屬性
        // 你可以簡單地訪問它
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
    }
}
