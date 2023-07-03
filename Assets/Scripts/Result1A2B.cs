using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Excel;
using System.Data;
using System.IO;
using OfficeOpenXml;

public class Result1A2B : MonoBehaviour
{
    public GameObject showName;
    public GameObject showCount;
    public GameObject showResult;
    public GameObject showTime;
    public GameObject showAnswer;
    public GameObject img;
    
    // Start is called before the first frame update
    void Start()
    {
        WriteExcel(showName, showCount, showResult, showTime, showAnswer, img, "gameResult.xlsx", "工作表1");
        
    }
    public static void WriteExcel(GameObject showName, GameObject showCount, GameObject showResult, GameObject showTime, GameObject showAnswer, GameObject img, string excelName, string sheetName){
        string path = excelName;
        FileInfo newFile = new FileInfo(path);
        int flag = 0; //記錄EXCEL是否已經存在， 0為不存在、1為存在

        if (newFile.Exists)
        {
            flag = 1;
        }
        else
        {
            flag = 0;
        }
        using (ExcelPackage package = new ExcelPackage(newFile))
        {
            ExcelWorksheet worksheet;
            int row_count = 0;// 剛開始的列數為0
            if (flag == 0)
            {
                //加入新的頁面，名稱為sheetName
                worksheet = package.Workbook.Worksheets.Add(sheetName);
                //加入列名
                worksheet.Cells[row_count + 1, 1].Value = "玩家名稱";
                worksheet.Cells[row_count + 1, 2].Value = "遊戲名稱";
                worksheet.Cells[row_count + 1, 3].Value = "遊玩時間";
                worksheet.Cells[row_count + 1, 4].Value = "通關結果";
                row_count = 1;
            }
            else
            {
                worksheet = package.Workbook.Worksheets[sheetName];//選擇已有的頁面sheetName
                row_count = worksheet.Dimension.Rows;//算出目前頁面的列數
                worksheet.Cells[row_count + 1, 1].Value = global.playerName;
                worksheet.Cells[row_count + 1, 2].Value = global.gameName;
                worksheet.Cells[row_count + 1, 3].Value = global.useTime + "秒";

                if(global.IAtoBResult)
                    worksheet.Cells[row_count + 1, 4].Value = "挑戰成功";
                else
                    worksheet.Cells[row_count + 1, 4].Value = "挑戰失敗";
                Debug.Log("成功");
            }
            

            //儲存
            package.Save();

        }
        showName.GetComponent<Text>().text = global.IAtoBName;
        showCount.GetComponent<Text>().text = global.IAtoBCount;
        if(global.IAtoBResult){
            img.GetComponent<Image>().sprite = Resources.Load<Sprite>("happy");
            showResult.GetComponent<Text>().text = "遊戲成功";
        }else{
            img.GetComponent<Image>().sprite = Resources.Load<Sprite>("crying");
            showResult.GetComponent<Text>().text = "遊戲失敗";
        }

        showTime.GetComponent<Text>().text = global.IAtoBTime;
        showAnswer.GetComponent<Text>().text = global.IAtoBAnswer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
