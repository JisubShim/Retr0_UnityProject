using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // 탄알 이동 속력
    private Rigidbody bulletRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f); // 3초 뒤에 자신의 게임 오브젝트 파괴
    }

    private void OnTriggerEnter(Collider other)
    {
        // 태그가 Player일 경우
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            // other 게임 오브젝트에 PlayerController 스크립트가 없으면 null 반환
            // 따라서 이렇게 실수를 대비해주어야 함
            if (playerController != null) 
            {
                playerController.Die();
            }
        }
    }
}
