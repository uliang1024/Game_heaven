using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed=0;
    GameObject car;
    // Start is called before the first frame update
    Vector2 startPo, endPo;
    public GameObject Audio;
    void Start()
    {
        car = GameObject.Find("car");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            speed=0.025F;                   //  賽車前進速度
            startPo= Input.mousePosition;
            Audio.GetComponent<AudioSource>().Play();
        }
        
        car.transform.Translate(speed,0,0); 
        speed*=0.98F;   //  賽車緩速
    }
}
