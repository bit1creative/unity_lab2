using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralMovement : MonoBehaviour
{
    float TimeCounter;
    float speed;
    float width;
    float min;
    float max;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        width = 5;
        min = 2f;
        max = 10f;
        TimeCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos (TimeCounter)*width;
        float y = 3;
        float z = Mathf.Sin(TimeCounter)*width;

        transform.position = new Vector3(x, Mathf.PingPong(Time.time * 2, max - min) + min, z);

    }
}
