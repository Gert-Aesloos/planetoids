using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class moonRotation : MonoBehaviour
{
    public Transform target;
    public float speed;
    [SerializeField]
    private float rotationAngle = 90f;


    // Update is called once per frame
    void Update()
    {
        // Increment the angle
        rotationAngle += speed * Time.deltaTime;

        // Convert angle to radians
        float radians = rotationAngle * Mathf.Deg2Rad;

        // Calculate new position in circular orbit around planet
        UnityEngine.Vector3 offset = new UnityEngine.Vector3(Mathf.Cos(radians), 0, Mathf.Sin(radians)) * 10;

        // Set the moon's position relative to the moving planet
        transform.position = target.position + offset;
    }
}
