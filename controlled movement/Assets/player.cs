using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;


public class player : MonoBehaviour{


    public Rigidbody body;
    public float speed;
    public int hitPoints = 100;


    void Start(){
        try{
          LoadProgress();
        }
        catch{
          //move on
        }


        body = GetComponent<Rigidbody>();

    }

    void Update(){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if(hor != 0 || ver != 0){
          Vector3 acceleration = new Vector3(0.5f*speed*hor,0, 0.5f*speed*ver);
          if(!(body.velocity.x > 2 || body.velocity.z > 2 || body.velocity.x < -2 || body.velocity.z < -2)){
            body.velocity += acceleration;
          }

        }
        // else{
        //   body.velocity = Vector3.zero;
        // }

        // int chanceOfHit = Random.Range(0, 30);
        // if(chanceOfHit == 7){
        //   hitPoints -= 4;
        // }
        // else if(chanceOfHit == 17){
        //   hitPoints -= 2;
        // }
        // else if(chanceOfHit == 28){
        //   hitPoints += 3;
        // }
        //
        // float save = Input.GetAxis("Jump");
        // if(save != 0){
        //   SaveProgress();
        // }

    }


    public void SaveProgress(){
      string hitPointValue = "" + hitPoints;
      File.WriteAllText("C:/Users/franc/Documents/delete/savedGame.txt", hitPointValue);
    }

    public void LoadProgress(){
      string savedGame = File.ReadAllText("C:/Users/franc/Documents/delete/savedGame.txt");
      if(savedGame != ""){
        string[] values = savedGame.Split('\n');
        hitPoints = int.Parse(values[0]);
      }
    }


}
