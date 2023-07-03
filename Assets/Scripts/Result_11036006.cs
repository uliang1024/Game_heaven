using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Result_11036006 : MonoBehaviour
{
    public GameObject Name, gameName, puzzleResult, useTime;
    // Start is called before the first frame update
    void Start()
    {
        Name.GetComponent<Text>().text = global.playerName;
        gameName.GetComponent<Text>().text = global.gameName ;
        useTime.GetComponent<Text>().text = "耗時 : " + global.useTime.ToString() + "秒";

        if(global.gameName == "拼圖遊戲")
            puzzleResult.GetComponent<Text>().text = global.puzzleResult;
        else if(global.gameName == "賽車遊戲")
            puzzleResult.GetComponent<Text>().text = global.racingResult;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
