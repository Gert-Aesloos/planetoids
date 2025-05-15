using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planteRotation : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float direction;
    [SerializeField]
    private float rotationAngle = 90f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position,new Vector3(0,direction,0),speed*Time.deltaTime);
        transform.Rotate(Vector3.up, rotationAngle*Time.deltaTime);
    }
}
