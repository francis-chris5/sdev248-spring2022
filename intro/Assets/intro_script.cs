using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intro_script : MonoBehaviour{

    private string name = "Chris";
    private int age = 43;
    private bool goingGray = true;
    Text outputBox;
    void Start(){
        outputBox = GetComponent<Text>();
        outputBox.text = name + " is " + age + " years old.\n";
        outputBox.text += goingGray + ", " + name + " is turning gray in his old age.\n";
    }

    void Update(){

    }
}//end class
