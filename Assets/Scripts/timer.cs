using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class timer : MonoBehaviour
{
    int timer_i = 0;
    bool timer_Start = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator settimer() {
        yield return new WaitForSeconds(1);
        timer_i ++;
        timer_Start = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(timer_Start){
            StartCoroutine("settimer");
            timer_Start = false;
            Debug.Log(timer_i);
        }
        if(global.stopTime == true){
            global.useTime = timer_i;
            StopCoroutine("settimer");
        }
    }
}
