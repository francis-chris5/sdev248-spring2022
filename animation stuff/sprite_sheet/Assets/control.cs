using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour{

    private Animator animator;


    void Start(){
      animator = GetComponent<Animator>();
    }

    void Update(){
      float hor = Input.GetAxis("Horizontal");
      if(hor != 0){
        animator.SetFloat("speed", 1);
      }
      else{
        animator.SetFloat("speed", 0);
      }



      float hit = Input.GetAxis("Jump");
      if(hit != 0){
        animator.SetBool("isPunching", true);
      }
      else{
        animator.SetBool("isPunching", false);
      }
    }
}
