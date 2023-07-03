using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    public float timeRemaining = 10;
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }


    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        if(length>0){
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                distance.GetComponent<Text>().text = "剩下" + string.Format("{0:f2}", timeRemaining)+ "秒" ;  
            }
            if (timeRemaining < 0){
                distance.GetComponent<Text>().text = "挑戰失敗" ; 
                global.racingResult = "挑戰失敗" ;
                global.stopTime = true;
            }
            // distance.GetComponent<Text>().text = "距離終點還有" + length.ToString("F2") + "m";   
        }else{
            distance.GetComponent<Text>().text = "抵達終點";     
            global.racingResult = "挑戰成功" ; 
            global.stopTime = true;
        }
        

    }
}
