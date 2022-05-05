using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour{
      public Transform focalObject;
      public Vector3 offset = new Vector3(1.0f, -3f, 2f);
      public float smoothing = 0.5f;

      public float pitch = 2.0f;
      public float yawSpeed = 90f;
      public float yawInput = 0f;

      private float currentZoom = 10f;
      private float zoomSpeed = 3f;
      private float minZoom = 1f;
      private float maxZoom = 2f;


      void Update(){

          yawInput -= Input.GetAxis("Mouse X");
          currentZoom -= Input.GetAxis("Mouse ScrollWheel")*zoomSpeed;
          currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

          Vector3 destination = focalObject.position + offset*currentZoom;
          Vector3 smoothMovement = Vector3.Lerp(transform.position, destination, smoothing);
          transform.position = smoothMovement;

            //for 3D
          transform.LookAt(focalObject.position + Vector3.up*pitch);
          transform.RotateAround(focalObject.position, Vector3.up, yawInput);
      }

}
