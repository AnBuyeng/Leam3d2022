using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirtor : MonoBehaviour
{
    public Text textTime;
    public Text textPoint;
    private float time = 60.0f;
    int point = 0;

    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point /= 2;
    }

    void Update()
    {
        this.time -= Time.deltaTime;
        this.textTime.text = this.time.ToString("F1");
        this.textPoint.text = this.point.ToString() + "point";
    }
}
