using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_look : MonoBehaviour
{
    public float mouseSens = 1000f;//�������� ����
    public Transform playerBody;//��� ���������
    float xRotation = 0f;//�� ��� �

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //������ ������ � ������� ����
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;//���������� ������� ���� ������ ��� �� ��� �
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;//���������� ������� ���� ������ ��� �� ��� �

        xRotation -= mouseY;//������ ������ �� ��� y
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);//����������� �� ������

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);//�������� ��������� �� �����
    }
}
