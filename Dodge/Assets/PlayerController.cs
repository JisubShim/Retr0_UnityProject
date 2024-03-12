using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) == true) // 위쪽 방향키 입력이 감지된 경우 z 방향 힘주기
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        
        if(Input.GetKey(KeyCode.DownArrow) == true) // 아래쪽 방향키 입력이 감지된 경우 -z 방향 힘주기
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if(Input.GetKey(KeyCode.RightArrow) == true) // 오른쪽 방향키 입력이 감지된 경우 x 방향 힘주기
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.LeftArrow) == true) // 왼쪽 방향키 입력이 감지된 경우 -x방향 힘주기
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    public void Die() 
    {
        gameObject.SetActive(false); // 자신의 게임 오브젝트 비활성화
    }
}
