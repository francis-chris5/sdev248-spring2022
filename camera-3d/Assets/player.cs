using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour{
    public float speed = 0.03f;

    void Update(){
      float hor = Input.GetAxis("Horizontal");
      float ver = Input.GetAxis("Vertical");

      if(hor != 0){
        Vector3 pos = new Vector3(transform.position.x + speed*hor, 1.5f,  transform.position.z);
        transform.position = pos;
      }

      if(ver != 0){
        Vector3 pos = new Vector3(transform.position.x, 1.5f, transform.position.z + speed*ver);
        transform.position = pos;
      }

    }//end update()
}//end class
