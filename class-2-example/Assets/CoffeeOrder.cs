using System.Collections;
using System.Collections.Generic;
using UnityEngine;



using UnityEngine.UI;

public class CoffeeOrder : MonoBehaviour{

      public Dropdown ddCoffee;
      public Toggle chkIced;
      public Text txtOrder;

      public void PlaceOrder(){
          string coffee = ddCoffee.options[ddCoffee.value].text;
          if(chkIced.isOn){
            txtOrder.text = "That's one iced " + coffee + " coffee.";
          }
          else{
            txtOrder.text = "That's one " + coffee + " coffee, hot.";
          }
      }

}
