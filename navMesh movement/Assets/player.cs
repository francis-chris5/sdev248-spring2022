using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class player : MonoBehaviour{

    NavMeshAgent agent;


    [SerializeField]
    Camera cam;

    void Start(){
      agent = GetComponent<NavMeshAgent>();


    }



    void Update(){
      if(Input.GetMouseButton(0)){
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 30)){
          move(hit.point);
        }
      }
    }


    public void move(Vector3 destination){
      if(destination != null){
        agent.SetDestination(destination);
      }
    }
}
