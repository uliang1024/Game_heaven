using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject wp;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 1;
        StartCoroutine(Change_Color());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Change_Color()
    {
        while(true)
        {
            Image img = wp.GetComponent<Image>();
            if (i == 1)
                img.color = UnityEngine.Color.white;
            if (i == 2)
                img.color = UnityEngine.Color.yellow;
            if (i == 3)
                img.color = UnityEngine.Color.gray;
            i++;
            if (i == 4)
                i = 1;
            yield return new WaitForSeconds(2.0f);
        }
    }
}
