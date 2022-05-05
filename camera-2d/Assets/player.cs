using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour{


    public float speed = 0.1f;

    void Start(){

    }

    void Update(){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if(hor != 0){
          Vector2 pos = new Vector2(transform.position.x + speed*hor, transform.position.y);
          transform.position = pos;
        }

        if(ver != 0){
          Vector2 pos = new Vector2(transform.position.x, transform.position.y + speed*ver);
          transform.position = pos;
        }
    }
}
