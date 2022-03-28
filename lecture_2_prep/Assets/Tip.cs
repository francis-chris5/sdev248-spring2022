using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour{

    public InputField txtPrice;
    public Slider sldQuality;
    public Text txtTip;

    public void Happiness(){
        float price = float.Parse(txtPrice.text);
        float tipAmount = price * sldQuality.value;
        txtTip.text = "You should tip $" + tipAmount + " then.";
    }
}
