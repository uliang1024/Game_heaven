using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game_11036006 : MonoBehaviour
{
    //物件宣告
    public GameObject img1,img2,img3,img4,img5,img6,img7,img8,img9;
    public GameObject txt_count;
    
    // Start is called before the first frame update
    void Start()
    {
        // 將各圖檔依照亂術後的順序，放入各img物件
        img1.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[0]);
        img2.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[1]);
        img3.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[2]);
        img4.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[3]);
        img5.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[4]);
        img6.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[5]);
        img7.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[6]);
        img8.GetComponent<Image>().sprite = Resources.Load <Sprite>("圖_0"+global.arr[7]);
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
            
    }
    // 判斷各img周邊是否有null的可以交換，每次交換成功後，累加count、比對是否完成
    public void onclick_img1(){
        if(img2.GetComponent<Image>().sprite == null){
            img2.GetComponent<Image>().sprite = img1.GetComponent<Image>().sprite;
            img1.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img4.GetComponent<Image>().sprite == null){
            img4.GetComponent<Image>().sprite = img1.GetComponent<Image>().sprite;
            img1.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }   
        check_success(); //交換後比對是否完成
    }
    public void onclick_img2(){
        //檢查左邊是否為空
        if(img1.GetComponent<Image>().sprite == null){  
            //移動拼圖
            img1.GetComponent<Image>().sprite = img2.GetComponent<Image>().sprite;
            img2.GetComponent<Image>().sprite = null;
            //累加拼圖次數
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img3.GetComponent<Image>().sprite == null){
            img3.GetComponent<Image>().sprite = img2.GetComponent<Image>().sprite;
            img2.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img5.GetComponent<Image>().sprite == null){
            img5.GetComponent<Image>().sprite = img2.GetComponent<Image>().sprite;
            img2.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }    
        //檢查拼圖是否成功
        check_success(); 
    }
    public void onclick_img3(){
        if(img2.GetComponent<Image>().sprite == null){
            img2.GetComponent<Image>().sprite = img3.GetComponent<Image>().sprite;
            img3.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img6.GetComponent<Image>().sprite == null){
            img6.GetComponent<Image>().sprite = img3.GetComponent<Image>().sprite;
            img3.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }
        check_success();
    }
    public void onclick_img4(){
        if(img1.GetComponent<Image>().sprite == null){
            img1.GetComponent<Image>().sprite = img4.GetComponent<Image>().sprite;
            img4.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img5.GetComponent<Image>().sprite == null){
            img5.GetComponent<Image>().sprite = img4.GetComponent<Image>().sprite;
            img4.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img7.GetComponent<Image>().sprite == null){
            img7.GetComponent<Image>().sprite = img4.GetComponent<Image>().sprite;
            img4.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        } 
        check_success();    
    }
    public void onclick_img5(){
        if(img6.GetComponent<Image>().sprite == null){
            img6.GetComponent<Image>().sprite = img5.GetComponent<Image>().sprite;
            img5.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img8.GetComponent<Image>().sprite == null){
            img8.GetComponent<Image>().sprite = img5.GetComponent<Image>().sprite;
            img5.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img4.GetComponent<Image>().sprite == null){
            img4.GetComponent<Image>().sprite = img5.GetComponent<Image>().sprite;
            img5.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img2.GetComponent<Image>().sprite == null){
            img2.GetComponent<Image>().sprite = img5.GetComponent<Image>().sprite;
            img5.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }  
        check_success();   
    }
    public void onclick_img6(){
        if(img9.GetComponent<Image>().sprite == null){
            img9.GetComponent<Image>().sprite = img6.GetComponent<Image>().sprite;
            img6.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img3.GetComponent<Image>().sprite == null){
            img3.GetComponent<Image>().sprite = img6.GetComponent<Image>().sprite;
            img6.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img5.GetComponent<Image>().sprite == null){
            img5.GetComponent<Image>().sprite = img6.GetComponent<Image>().sprite;
            img6.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }
        check_success();     
    }
    public void onclick_img7(){
        if(img8.GetComponent<Image>().sprite == null){
            img8.GetComponent<Image>().sprite = img7.GetComponent<Image>().sprite;
            img7.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img4.GetComponent<Image>().sprite == null){
            img4.GetComponent<Image>().sprite = img7.GetComponent<Image>().sprite;
            img7.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }    
        check_success();
    }
    public void onclick_img8(){
        if(img9.GetComponent<Image>().sprite == null){
            img9.GetComponent<Image>().sprite = img8.GetComponent<Image>().sprite;
            img8.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img7.GetComponent<Image>().sprite == null){
            img7.GetComponent<Image>().sprite = img8.GetComponent<Image>().sprite;
            img8.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img5.GetComponent<Image>().sprite == null){
            img5.GetComponent<Image>().sprite = img8.GetComponent<Image>().sprite;
            img8.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        } 
        check_success();   
    }
    public void onclick_img9(){
        if(img6.GetComponent<Image>().sprite == null){
            img6.GetComponent<Image>().sprite = img9.GetComponent<Image>().sprite;
            img9.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }else if(img8.GetComponent<Image>().sprite == null){
            img8.GetComponent<Image>().sprite = img9.GetComponent<Image>().sprite;
            img9.GetComponent<Image>().sprite = null;
            global.count += 1;
            txt_count.GetComponent<Text>().text = global.count.ToString();
        }    
        check_success();
    }
    public void check_success(){  //比對拼對的數量
        int success=0; 
        
        if(img1.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_01"))
            success +=1;
        if(img2.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_02"))
            success +=1;   
        if(img3.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_03"))
            success +=1;
        if(img4.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_04"))
            success +=1;
        if(img5.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_05"))
            success +=1;
        if(img6.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_06"))
            success +=1;
        if(img7.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_07"))
            success +=1;
        if(img8.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_08"))
            success +=1;
        if(img9.GetComponent<Image>().sprite == Resources.Load<Sprite>("圖_09"))
            success +=1;
        if(success == 8){
            Debug.Log("success");
            global.puzzleResult = "挑戰成功";
            fill_missingPiece();
        }else{
            global.puzzleResult = "挑戰失敗";
        }
    }
    public void fill_missingPiece(){  //填滿缺少的拼圖
        if(img1.GetComponent<Image>().sprite == null)
            img1.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_01");
        else if(img2.GetComponent<Image>().sprite == null)
            img2.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_02");
        else if(img3.GetComponent<Image>().sprite == null)
            img3.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_03");
        else if(img4.GetComponent<Image>().sprite == null)
            img4.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_04");
        else if(img5.GetComponent<Image>().sprite == null)
            img5.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_05");
        else if(img6.GetComponent<Image>().sprite == null)
            img6.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_06");
        else if(img7.GetComponent<Image>().sprite == null)
            img7.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_07");
        else if(img8.GetComponent<Image>().sprite == null)
            img8.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_08");
        else if(img9.GetComponent<Image>().sprite == null)
            img9.GetComponent<Image>().sprite = Resources.Load<Sprite>("圖_09");
    }
}
