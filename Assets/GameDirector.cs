using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // TextMeshProをインポート

public class GameDirector : MonoBehaviour
{
    // フィールドを定義
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        // オブジェクトを見つける
        this.car = GameObject.Find("car_0");
        this.flag = GameObject.Find("flag_0");
        this.distance = GameObject.Find("distance");
    }

    void Update()
    {
        // 旗と車の距離を算出
        float length = this.flag.transform.position.x -
            this.car.transform.position.x;

        // 旗に近づいたときの判定
        if (length >= 0.1F)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text =
                "Distance: " + length.ToString("F2") + "m";
        }
        else if (length < 0.1F && length > -0.15F)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text =
                "Good!";
        }
        else
        {
            this.distance.GetComponent<TextMeshProUGUI>().text =
                "GameOver";
        }
    }
}
