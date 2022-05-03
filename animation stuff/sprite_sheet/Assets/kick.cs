using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{
    public GameObject leg;
    private float angle = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float kick = Input.GetAxis("Jump");
        if(kick != 0){

          if(angle < 90){
            angle += 3;
          }

          leg.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else{

          if (angle > 0){
            angle -= 3;
          }
          leg.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
