using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a Number and do not tell me what it is...");
        Debug.Log("The Highest number you can choose is " +max);
        Debug.Log("The Lowest number you can choose is " +min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
