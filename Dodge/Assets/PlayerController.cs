using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // �̵��� ����� Rigidbody ������Ʈ
    public float speed = 8f; // �̵� �ӷ�
    
    void Start()
    {
        // ���� ������Ʈ���� RigidBody�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        /* if (Input.GetKey(KeyCode.UpArrow) == true) // ���� ����Ű �Է��� ������ ��� z ���� ���ֱ�
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) // �Ʒ��� ����Ű �Է��� ������ ��� -z ���� ���ֱ�
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true) // ������ ����Ű �Է��� ������ ��� x ���� ���ֱ�
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) // ���� ����Ű �Է��� ������ ��� -x���� ���ֱ�
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        } */

        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // Rigidbody�� velocity�� newVelocity �Ҵ�
        // �밢������ �̵��� �� �� ���� �����̴� ���� ����
        Vector3 newVelocity = new Vector3(xInput, 0f, zInput).normalized * speed; 
        playerRigidbody.velocity = newVelocity;
    }

    public void Die() // Ŭ���� �ܺο��� ����� �޼ҵ�
    {
        gameObject.SetActive(false); // �ڽ��� ���� ������Ʈ ��Ȱ��ȭ
    }
}
