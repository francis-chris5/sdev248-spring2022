using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour{

    public Transform focalObject;
    public Vector3 offset = new Vector3(1.0f, 1.0f, -10);
    public float smoothing = 0.5f;


    void Update(){

        Vector3 destination = focalObject.position + offset;
        Vector3 smoothMovement = Vector3.Lerp(transform.position, destination, smoothing);
        transform.position = smoothMovement;

          //for 3D
        //transform.LookAt(target);
    }
}
