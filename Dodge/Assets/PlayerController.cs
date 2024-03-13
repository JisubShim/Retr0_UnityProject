using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // 이동에 사용할 Rigidbody 컴포넌트
    public float speed = 8f; // 이동 속력
    
    void Start()
    {
        // 게임 오브젝트에서 RigidBody를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        /* if (Input.GetKey(KeyCode.UpArrow) == true) // 위쪽 방향키 입력이 감지된 경우 z 방향 힘주기
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) // 아래쪽 방향키 입력이 감지된 경우 -z 방향 힘주기
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true) // 오른쪽 방향키 입력이 감지된 경우 x 방향 힘주기
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) // 왼쪽 방향키 입력이 감지된 경우 -x방향 힘주기
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        } */

        // 수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // Rigidbody의 velocity에 newVelocity 할당
        // 대각선으로 이동할 때 더 빨리 움직이는 버그 수정
        Vector3 newVelocity = new Vector3(xInput, 0f, zInput).normalized * speed; 
        playerRigidbody.velocity = newVelocity;
    }

    public void Die() // 클래스 외부에서 실행될 메소드
    {
        gameObject.SetActive(false); // 자신의 게임 오브젝트 비활성화
    }
}
