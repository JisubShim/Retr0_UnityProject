using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f); // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
    }

    private void OnTriggerEnter(Collider other)
    {
        // �±װ� Player�� ���
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            // other ���� ������Ʈ�� PlayerController ��ũ��Ʈ�� ������ null ��ȯ
            // ���� �̷��� �Ǽ��� ������־�� ��
            if (playerController != null) 
            {
                playerController.Die();
            }
        }
    }
}
