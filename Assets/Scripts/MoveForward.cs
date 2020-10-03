using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(0, 0, 0);
        pointB = new Vector3(10, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}