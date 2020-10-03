using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{
    float TimeCounter;
    float speed;
    float a;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        TimeCounter = 0;
        a = 5;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCounter += Time.deltaTime * speed;

        float y = 10 + a / 4 * (3 * Mathf.Sin(TimeCounter) - Mathf.Sin(3*TimeCounter)); // +10 щоб циліндр був вище і не провалювався
        float x = a / 4 * (3 * Mathf.Cos(TimeCounter) + Mathf.Cos(3*TimeCounter));
        float z = 10;

        transform.position = new Vector3(x, y, z);
    }
}
