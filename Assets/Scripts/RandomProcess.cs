using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomProcess : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] a = new int[4];

		bool repeat = false;

        do {
			int pwd = 0;
			pwd = Random.Range(0123,9877);
			int x = 1000;
			
			for(int k = 0;k < a.Length;k++) {
				a[k] = pwd / (int)x;
				pwd = pwd % (int)x;
				x = x / 10;
			}
			
			repeat = false;
			
			for(int i = 0;i < a.Length && repeat == false;i++) {
				for(int j = i+1;j < a.Length && repeat == false;j++) {
					if(a[i]==a[j]) {
						repeat = true;
                        break;
					}else {
						repeat = false;
					}
				}	
			}
		}while(repeat == true);

        for(int k = 0;k < a.Length;k++) {
			global.CompleteLpcation[k] = (a[k]).ToString();
		}
    }
}
