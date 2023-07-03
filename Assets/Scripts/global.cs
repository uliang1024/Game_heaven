using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global : MonoBehaviour
{
    public static string input_data,playerName, gameName, puzzleResult, racingResult;
    public static int count, useTime;
    public static bool numberSet = false;
    public static string IAtoBName;
    public static string IAtoBCount;
    public static bool IAtoBResult;

    public static string IAtoBTime;
    public static string IAtoBAnswer;

    public static string[] CompleteLpcation = new string[4];

    public static bool stopTime = false;
    public static int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9}; //圖片順序陣列
}
