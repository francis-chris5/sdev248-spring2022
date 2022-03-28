using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GrossPay : MonoBehaviour{

    public InputField txtName;
    public InputField txtRate;
    public InputField txtHours;
    public Text txtGross;

    public void CalculateGrossPay(){
      string name = txtName.text;
      float rate = float.Parse(txtRate.text);
      float hours = float.Parse(txtHours.text);
      float gross;
      if(hours <= 40){
        gross = rate * hours;
      }
      else{
        gross = rate * 40 + 1.5f * rate * (hours - 40);
      }
      txtGross.text = name + " made $" + gross + " this pay period.";
    }

}
