using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;
using UnityEngine.SceneManagement;

public class Q2 : MonoBehaviour
{
    FlowerSystem fs;
    // Start is called before the first frame update
    void Start()
    {

        fs = FlowerManager.Instance.GetFlowerSystem("defult");
        fs.ReadTextFromResource("Q2");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            fs.Next();
        }
    }
}
