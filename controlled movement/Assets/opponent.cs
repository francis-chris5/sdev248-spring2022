using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opponent : character{

    public bool isAttacking = false;
    public player player;
    int timer = 300;

    void LateUpdate(){
      float distance = Mathf.Sqrt((body.transform.position.x - player.transform.position.x)*(body.transform.position.x - player.transform.position.x) + (body.transform.position.z - player.transform.position.z) * (body.transform.position.z - player.transform.position.z));
      //&& Random.Range(0, 100) == 7 //alternative to timer, adjust probability
      if(distance < 3f  && timer == 60){
        isAttacking = !isAttacking;
      }
      if(isAttacking){
        direction = player.transform.position - transform.position;
        speed = 6;
        direction = direction * speed;
        body.velocity =direction;
        timer = 1;
        isAttacking = !isAttacking;
        player.hitPoints -= 5;
      }

      if(timer == 10){
        speed = 2;
        ChangeDirection();
      }

      timer++;
    }
}
