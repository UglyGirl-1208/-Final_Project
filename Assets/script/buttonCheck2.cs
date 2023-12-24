using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonCheck2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameManger2 gameManager2; // 參考到遊戲管理器的腳本
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
        gameManager2.OnButtonPressed(gameObject);
    }
}