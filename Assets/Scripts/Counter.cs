using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCounter : MonoBehaviour
{
    [SerializeField] Text txtDisNum;
    int counter = 0 ;

    void Start()
    {
        DisplayTheNum();        
    }
    public void IncAnsDisBody(){
        counter++;
        DisplayTheNum();
    }
    public void IncAnsDisHead(){
        int ran0 = Random.Range(0, 3);
        if(ran0 == 0){
            int ran1 = Random.Range(3, 10);
            counter += ran1;
            DisplayTheNum();


        }

    }
    public void DisplayTheNum() {    
     txtDisNum.text = "Score: " + counter.ToString();
        
    }
    
        
}
