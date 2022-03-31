using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelHealth : MonoBehaviour
{
    public int levelHealth = 100; //��
    public Slider mySlider;//�������� ��������
    public Image myImage;//�������� ��������

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mySlider.value = levelHealth;// ����������� �������� �������� ��
        if (levelHealth < 10)
        {
            myImage.enabled = false;
        }
        else
        {
            myImage.enabled = true;
        }
    }
}
