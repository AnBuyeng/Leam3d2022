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
        this.car = GameObject.Find("car"); //게임 오브젝트 찾기
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float Length = this.flag.transform.position.x - this.car.transform.position.x;
        if(Length >=0)
        {
            this.distance.GetComponent<Text>().text = "목표지점까지" + Length.ToString("F2")+"m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임오버!";
        }
        //float Length = this.flag.transform.position.x - this.car.transform.position.x;

        //Text txDistance = this.distance.GetComponent<Text>();
        //txDistance.text = string.Format("목표지점까지 {0}m", Length.ToString("F2"));
    }
}
