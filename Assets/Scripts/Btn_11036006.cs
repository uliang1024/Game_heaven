using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Security.Cryptography;
using System;
public class Btn_11036006 : MonoBehaviour
{
    public GameObject InputText;
    public GameObject Panel, Count;
    
    
    public static System.Random ran = new System.Random(); //亂數宣告
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick_btn_inPuzzleGame(){      //進入 拼圖遊戲 Button
        global.arr = global.arr.OrderBy(x => ran.Next()).ToArray(); //將array重新用亂數排序
        global.playerName = InputText.GetComponent<InputField>().text; //取得玩家名稱
        SceneManager.LoadScene("Game"); //切換scene->Game
        global.count = 0; //初始化拼圖交換次數
        global.puzzleResult = "失敗";
        global.gameName = "拼圖遊戲";
        global.stopTime = false;
        
    }
    public void onClick_btn_startGame(){    //開始遊戲Button
        Panel.SetActive(true);
    }
    public void onClick_btn_inCarGame(){    //car 遊戲 Button 
        global.playerName = InputText.GetComponent<InputField>().text;
        SceneManager.LoadScene("Car");
        global.gameName = "賽車遊戲";
        global.racingResult = "失敗" ; 
        global.stopTime = false;

    }
    public void onClick_btn_inNumGame(){    //1A2B 遊戲 Button 
        global.playerName = InputText.GetComponent<InputField>().text;
        SceneManager.LoadScene("Main_1A2B");
        global.gameName = "1A2B遊戲";
        global.IAtoBResult = false ; 
        global.stopTime = false;

    }
    public void onClick_btn_inHandGame(){    //剪刀石頭布 遊戲 Button 
        global.playerName = InputText.GetComponent<InputField>().text;
        SceneManager.LoadScene("rock_paper_scissors");
        global.gameName = "剪刀石頭布";
        global.racingResult = "失敗" ; 
        global.stopTime = false;
        global.count = 0;
    }
    public void onClick_btn_Result(){    //結束遊戲Button 
        SceneManager.LoadScene("Result");
        
        if(global.gameName == "拼圖遊戲")
            Panel.SetActive(false); 
        global.stopTime = true;

    }
    public void onClick_btn_backHome(){    //回首頁Button 
        SceneManager.LoadScene("Main");
    }
}
