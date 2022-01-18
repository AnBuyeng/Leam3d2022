using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDircter : MonoBehaviour
{
    private GameObject car;
    private GameObject flag;
    private GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car"); //���� ������Ʈ ã��
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float Length = this.flag.transform.position.x - this.car.transform.position.x;
        if(Length >=0)
        {
            this.distance.GetComponent<Text>().text = "��ǥ��������" + Length.ToString("F2")+"m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "���ӿ���!";
        }
        //float Length = this.flag.transform.position.x - this.car.transform.position.x;

        //Text txDistance = this.distance.GetComponent<Text>();
        //txDistance.text = string.Format("��ǥ�������� {0}m", Length.ToString("F2"));
    }
}
