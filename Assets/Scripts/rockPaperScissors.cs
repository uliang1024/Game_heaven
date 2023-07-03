using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class rockPaperScissors : MonoBehaviour
{
    public GameObject scissorsImg,rockImg,paperImg,cpu;
    public GameObject winTxt,loseTxt,result,blackScreen;
    int cpuChoice = 0;
    public float timer_f = 0;
    public int timer_i = 0;
    // Start is called before the first frame update
    void Start()
    {
        winTxt.GetComponent<Text>().text = "0";
        winTxt.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        timer_f = Time.timeSinceLevelLoad;
        timer_i = Mathf.FloorToInt(timer_f);
    }

    public void scissors_Event()
    {
        cpuChoice = Random.Range(0,3);
        show();
        if(cpuChoice == 2){
            winTxt.GetComponent<Text>().text = (Int32.Parse(winTxt.GetComponent<Text>().text)+1).ToString();
            result.GetComponent<Text>().text = "勝";
        }else if(cpuChoice == 0){
            result.GetComponent<Text>().text = "平手";
        }else{
            loseTxt.GetComponent<Text>().text = (Int32.Parse(loseTxt.GetComponent<Text>().text)+1).ToString();
            result.GetComponent<Text>().text = "敗";
        }
        check();
    }

    public void rock_Event()
    {
        cpuChoice = Random.Range(0,3);
        show();
        if(cpuChoice == 0){
            winTxt.GetComponent<Text>().text = (Int32.Parse(winTxt.GetComponent<Text>().text)+1).ToString();
            result.GetComponent<Text>().text = "勝";
        }else if(cpuChoice == 1){
            result.GetComponent<Text>().text = "平手";
        }else{
            loseTxt.GetComponent<Text>().text = (Int32.Parse(loseTxt.GetComponent<Text>().text)+1).ToString();
            result.GetComponent<Text>().text = "敗";
        }
        check();
    }

    public void paper_Event()
    {
        cpuChoice = Random.Range(0,3);
        show();
        if(cpuChoice == 1){
            winTxt.GetComponent<Text>().text = (Int32.Parse(winTxt.GetComponent<Text>().text)+1).ToString();
            result.GetComponent<Text>().text = "勝";
        }else if(cpuChoice == 2){
            result.GetComponent<Text>().text = "平手";
        }else{
            loseTxt.GetComponent<Text>().text = (Int32.Parse(loseTxt.GetComponent<Text>().text)+1).ToString();
            result.GetComponent<Text>().text = "敗";
        }
        check();
    }

    void show()
    {
        if(cpuChoice == 0 ){
            cpu.GetComponent<Image>().sprite = Resources.Load<Sprite>("scissors");
        }else if(cpuChoice == 1 ){
            cpu.GetComponent<Image>().sprite = Resources.Load<Sprite>("rock");
        }else{
            cpu.GetComponent<Image>().sprite = Resources.Load<Sprite>("paper");
        }
    }

    void check()
    {
        int win = Int32.Parse(winTxt.GetComponent<Text>().text);
        int lose = Int32.Parse(loseTxt.GetComponent<Text>().text);
        if(win>= 5){
            global.racingResult = "挑戰成功";
            global.useTime = timer_i;
            SceneManager.LoadScene("Result");
        }else if(lose >= 5 ){
            global.racingResult = "挑戰失敗";
            global.useTime = timer_i;
            SceneManager.LoadScene("Result");
        }else{
            blackScreen.SetActive(true);
        }
    }

    public void close_blackScreen()
    {
        cpu.GetComponent<Image>().sprite = Resources.Load<Sprite>("question-mark");
        blackScreen.SetActive(false);
    }
}
