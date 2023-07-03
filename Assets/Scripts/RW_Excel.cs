using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Excel;
using System.Data;
using System.IO;
using OfficeOpenXml;

public class RW_Excel : MonoBehaviour
{
    public GameObject playerName, gameName, useTime, gameResult;
    void Start()
    {
        WriteExcel(playerName, gameName, useTime, gameResult, "gameResult.xlsx", "工作表1");
    }
    

    public static void WriteExcel(GameObject playerName, GameObject gameName, GameObject useTime, GameObject gameResult, string excelName, string sheetName)
    {
        //excel的路徑
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

        //使用ExcelPackage打開Excel
        using (ExcelPackage package = new ExcelPackage(newFile))
        {
            ExcelWorksheet worksheet;
            int row_count = 0;// 初始化列數為0
            if (flag == 0)
            {
                //加入新的頁面，名稱為sheetName
                worksheet = package.Workbook.Worksheets.Add(sheetName);
                //加入列
                worksheet.Cells[row_count + 1, 1].Value = "玩家名稱";
                worksheet.Cells[row_count + 1, 2].Value = "遊戲名稱";
                worksheet.Cells[row_count + 1, 3].Value = "遊玩時間";
                worksheet.Cells[row_count + 1, 4].Value = "通關結果";
                row_count = 1;
            }
            else
            {
                worksheet = package.Workbook.Worksheets[sheetName];//選擇頁面
                row_count = worksheet.Dimension.Rows;               //計算目前頁面的列數
                //開始寫入資料
                worksheet.Cells[row_count + 1, 1].Value = global.playerName; 
                worksheet.Cells[row_count + 1, 2].Value = global.gameName;
                worksheet.Cells[row_count + 1, 3].Value = global.useTime + "秒";
                if(global.gameName == "拼圖遊戲"){
                    worksheet.Cells[row_count + 1, 4].Value = global.puzzleResult;
                    gameResult.GetComponent<Text>().text = global.puzzleResult;
                }
                else if(global.gameName == "賽車遊戲"){
                    worksheet.Cells[row_count + 1, 4].Value = global.racingResult;
                    gameResult.GetComponent<Text>().text = global.racingResult;
                }
                else{
                    worksheet.Cells[row_count + 1, 4].Value = global.racingResult;
                    gameResult.GetComponent<Text>().text = global.racingResult;
                }

                // 在畫面顯示使用者資訊與結果
                playerName.GetComponent<Text>().text = global.playerName;    
                gameName.GetComponent<Text>().text = global.gameName;
                useTime.GetComponent<Text>().text = global.useTime.ToString() + "秒";
                Debug.Log("成功");
            }
            

            //儲存
            package.Save();

        }
    }
}

