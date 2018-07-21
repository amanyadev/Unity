using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothspeed = 0.125f;
    public Vector3 offset ;
    

    void LateUpdate()
    {
        Vector3 desiredposition = target.position + offset;
        Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition, smoothspeed);
        target.position = smoothedposition;
        transform.LookAt(target);
    }

}