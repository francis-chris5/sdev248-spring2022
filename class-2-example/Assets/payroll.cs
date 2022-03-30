using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class payroll : MonoBehaviour{
      public InputField txtName;
      public InputField txtRate;
      public InputField txtHours;
      public Text txtGrossPay;

      public void GrossPay(){
          string name = txtName.text;
          float rate = float.Parse(txtRate.text);
          float hours = float.Parse(txtHours.text);
          float grossPay;
          if(hours <= 40){
              grossPay = rate * hours;
          }
          else{
              grossPay = rate * 40 + 1.5f * rate * (hours - 40);
          }
          txtGrossPay.text = name + " made " + grossPay + " this pay period.";
      }

}//end payroll class
