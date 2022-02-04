using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float move_speed = 1.0f; //속도초기값을 지정함
    float x_speed = 0;//x축 방향의 속도변수
    float y_speed = 0;//y축 방향의 속도변수 
    bool leftFleg = false; //방향전환을 위한 변수(참, 거짓)
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_speed = 0;
        y_speed = 0;

        if (Input.GetKey("right")) 
        {
            x_speed = move_speed;//우측 화살표를 누르다면 x_speed만큼 우측으로 움직여라
            leftFleg = false;//참 또는 거짓 값을 대입
        } 

        if (Input.GetKey("left"))
        {
            x_speed = -move_speed;//좌측 화살표를 누르다면 x_speed만큼 좌측으로 움직여라
            leftFleg = true;
        } 
                     
        if (Input.GetKey("up"))
        {
            y_speed = move_speed;//우측 화살표를 누르다면 y_speed만큼 위로 움직여라

        } 

        if (Input.GetKey("down"))//우측 화살표를 누르다면 -y_speed만큼 아래로 움직여라
        {
            y_speed = -move_speed;
            
        } 


    }
    private void FixedUpdate()//매초마다 동일한 프레임을 위해서
    {
        this.transform.Translate(x_speed, y_speed, 0);//상하좌우 화살표를 누를 때, 오브젝트를 이동하라 
        this.GetComponent<SpriteRenderer>().flipX = leftFleg;//좌우로 움직일 때, 스프라이트 방향전환
    }
}
