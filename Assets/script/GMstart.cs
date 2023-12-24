using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMstart : MonoBehaviour
{
    public string nextSceneName = "intro"; // 下一個場景的名稱
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 載入下一個場景
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
