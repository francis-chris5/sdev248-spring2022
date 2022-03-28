using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Coffee : MonoBehaviour{

    public Dropdown ddChoice;
    public Toggle chkIced;
    public Text txtOrder;

    public void PlaceOrder(){
        string coffee = ddChoice.options[ddChoice.value].text;
        if(chkIced.isOn){
            txtOrder.text = "That's one iced " + coffee + ".";
        }
        else{
            txtOrder.text = "That's one " + coffee + " coffee, hot.";
        }
    }
}
