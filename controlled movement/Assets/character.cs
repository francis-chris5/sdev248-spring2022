using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour{
  public Rigidbody body;
  public float speed = 2;
  public Vector3 direction;
  private int frame;

  void Start(){
    body = GetComponent<Rigidbody>();
    ChangeDirection();
  }

  void Update(){


      if(frame % 222 == 0 || transform.position.x <= -9 || transform.position.x >= 9 || transform.position.z <= -9 || transform.position.z >= 9 ){
        ChangeDirection();
      }


      if(!(body.velocity.x >3 || body.velocity.z > 3 || body.velocity.x < -3 || body.velocity.z < -3)){
        body.velocity += direction;
      }
      frame++;
    }


    public void ChangeDirection(){
      int newDirection = Random.Range(0, 8);
      body.velocity = Vector3.zero;
      switch(newDirection){
        case 0:
          direction = new Vector3(speed, 0, 0);
          break;
        case 1:
          direction = new Vector3(0.5f * speed, 0, 0.5f * speed);
          break;
        case 2:
          direction = new Vector3(0, 0, speed);
          break;
        case 3:
          direction = new Vector3(-0.5f * speed, 0, 0.5f * speed);
          break;
        case 4:
          direction = new Vector3(-speed, 0, 0);
          break;
        case 5:
          direction = new Vector3(-0.5f * speed, 0, -0.5f * speed);
          break;
        case 6:
          direction = new Vector3(0, 0, -speed);
          break;
        case 7:
          direction = new Vector3(0.5f * speed, 0, -0.5f * speed);
          break;
      }
    }
}//end character class
