using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BC5 : MonoBehaviour
{
    public GM5 gameManager5; // 參考到遊戲管理器的腳本
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        // 按下按鈕時呼叫遊戲管理器的函數
        gameManager5.OnButtonPressed(gameObject);
    }
}
