using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//유니티 씬을 이용하기위해 꼭 필요한 옵션
public class Ui_Act : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("A"))//A키를 누른다면
        {
            SceneManager.LoadScene("GameOver");//"GameOver"화면으로 넘어가라
        }
    }
}
