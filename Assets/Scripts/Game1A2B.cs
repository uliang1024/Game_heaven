using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class Game1A2B : MonoBehaviour
{
    public GameObject record;
    public List<Button> buttons = new List<Button>();
    public GameObject inputTxt,inputError,CellPrefab,txt_time,txt_count;
    public InputField inputField;
    public string input_data,time_data,data_answer;
    public bool result_data=false;
    public float timer_f = 0;
    public int timer_i = 0;
    public int count = 0, total=10;
    
    
    // Start is called before the first frame update
    void Start()
    {
        AddClickEvents();
    }

    // Update is called once per frame
    void Update()
    {
        timer_f = Time.timeSinceLevelLoad;
        timer_i = Mathf.FloorToInt(timer_f);
        int minute = timer_i / 60;
        int second = timer_i % 60;
        time_data = minute.ToString("00") + ":" + second.ToString("00");
        txt_time.GetComponent<Text>().text = time_data;


        input_data = inputField.GetComponent<InputField>().text;
        for(int i = 0;i < input_data.Length;i++) {
            for(int j = i+1;j < input_data.Length ;j++) {
                if(input_data[i] == input_data[j]) {
                    inputError.GetComponent<Text>().text = "每個數字需要不相同.";
                    inputField.text = inputField.text.Substring(0,inputField.text.Length - 1);
                }
            }	
        }
    }

    void AddClickEvents()
    {
        for(int i = 0; i < buttons.Count; i++){
            int j = i;
            buttons[i].onClick.AddListener(() => ClickEvent(j));
        }
    }
    void ClickEvent(int a)
    {
        switch (buttons[a].name)
        {
            case "btn0":
                ClickNumberButton(0);
                break;
            case "btn1":
                ClickNumberButton(1);
                break;
            case "btn2":
                ClickNumberButton(2);
                break;
            case "btn3":
                ClickNumberButton(3);
                break;
            case "btn4":
                ClickNumberButton(4);
                break;
            case "btn5":
                ClickNumberButton(5);
                break;
            case "btn6":
                ClickNumberButton(6);
                break;
            case "btn7":
                ClickNumberButton(7);
                break;
            case "btn8":
                ClickNumberButton(8);
                break;
            case "btn9":
                ClickNumberButton(9);
                break;
            case "endGame":
                endGame();
                break;
            case "hint":
                hint();
                break;
            case "check":
                check();
                break;
            case "backspace":
                backspace();
                break;
            default:
                break;
        }
    }
    

    void ClickNumberButton(int a)
    {
        inputError.GetComponent<Text>().text = "";
        inputField.text += a.ToString();  
    }

    public void check()
    {
        input_data = inputField.GetComponent<InputField>().text;
        if(input_data.Length != 4){
            inputError.GetComponent<Text>().text = "您每次需要輸入4個數字.";
        }else{
            int A=0,B=0;
            for(int i = 0;i < global.CompleteLpcation.Length;i++) {
                for(int j = 0;j < input_data.Length ;j++) {
                    
                    if(global.CompleteLpcation[i] == Char.ToString(input_data[j]) && i == j) {
                        A++;
                    }else if(global.CompleteLpcation[i] == Char.ToString(input_data[j])) {
                        B++;
                    }else {
                        //沒事發生
                    }
                    
                }	
            }

            if(A == 4) {
				Debug.Log("4A");
                count +=1;
                result_data = true;
                if(result_data){
                    global.IAtoBResult = true;
                }else{
                    global.IAtoBResult = false;
                }
                global.IAtoBName = "1A2B";
                global.IAtoBCount = Convert.ToString(count);

                for(int k = 0;k < global.CompleteLpcation.Length;k++) {
                    data_answer += global.CompleteLpcation[k];
                }

                global.IAtoBAnswer = data_answer;
                global.IAtoBTime = time_data;
                global.stopTime = true;


				SceneManager.LoadScene("Result_1A2B");
			}else {

                count +=1;
				GameObject obj = Instantiate(CellPrefab);
                obj.transform.SetParent(record.transform);
                GameObject obj2 = obj.transform.GetChild(0).gameObject;
                GameObject obj3 = obj.transform.GetChild(1).gameObject;
                obj2.GetComponent<Text>().text = input_data;
                obj3.GetComponent<Text>().text = A+"A"+B+"B";
                obj.transform.localScale = new Vector3(1,1,1);
                post_processing();
			}
        }
    }

    public void backspace()
    {
        string numstring = inputField.text;
 
        if (numstring.Length > 0) {
            inputField.text = numstring.Remove (numstring.Length - 1);
        } else {
            inputField.text = "";
        }
    }

    public void hint()
    {
        data_answer="";
        for(int k = 0;k < global.CompleteLpcation.Length;k++) {
            data_answer += global.CompleteLpcation[k];
        }
        inputField.text = data_answer;
    }

    public void endGame()
    {
        if(result_data){
            global.IAtoBResult = true;
        }else{
            global.IAtoBResult = false;
        }
        global.IAtoBName = "1A2B";
        global.IAtoBCount = Convert.ToString(count);

        for(int k = 0;k < global.CompleteLpcation.Length;k++) {
            data_answer += global.CompleteLpcation[k];
        }

        global.IAtoBAnswer = data_answer;
        global.IAtoBTime = time_data;
        global.stopTime = true;


        SceneManager.LoadScene("Result_1A2B");
    }

    public void post_processing()
    {
        inputField.text = "";
        txt_count.GetComponent<Text>().text = Convert.ToString(total-count);
        if( total - count <= 0 )
        {
            global.IAtoBName = "1A2B";
            global.IAtoBCount = Convert.ToString(count);
            global.IAtoBResult = false;
            for(int k = 0;k < global.CompleteLpcation.Length;k++) {
                data_answer += global.CompleteLpcation[k];
            }
            global.IAtoBAnswer = data_answer;
            global.IAtoBTime = time_data;
            global.stopTime = true;

            SceneManager.LoadScene("Result_1A2B");
        }
    }
}
