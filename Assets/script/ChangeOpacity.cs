using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOpacity : MonoBehaviour
{


    private Material myMaterial;
    //private int clickCount = -1; // 記錄按下按鈕的次數
    private float opacityValues = 1.0f; 

    // Start is called before the first frame update
    void Start()
    {
        // 獲取圖片物件的材質
        Renderer renderer = GetComponent<Renderer>();
        myMaterial = renderer.material;

    }

    // Update is called once per frame
    void Update()
    {
    }


    public void SetOpacity()
    {
        // 修改材質透明度
        Color color = myMaterial.color;
        color.a = opacityValues;
        myMaterial.color = color;


    }


    //public void turnOn()
       // {
        //clickCount = (clickCount + 1) % 2; // 每次點擊後切換到下一個透明度值
        //float opacityValue = opacityValues;
        //SetOpacity(opacityValue);
        
       
     //}



}
