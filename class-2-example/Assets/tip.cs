using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class tip : MonoBehaviour{
      public InputField ifMealPrice;
      public Slider sldSatisfaction;
      public Text txtTip;

      public void Happiness(){
          float price = float.Parse(ifMealPrice.text);
          float tipPercent = sldSatisfaction.value;
          txtTip.text = "Leave $" + price * tipPercent + " for a tip.";
      }
}
