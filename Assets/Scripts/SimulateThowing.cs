using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateThowing : MonoBehaviour
{
    public float throwForce = 200;
    public Rigidbody rb;
    private bool _jump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        readInput();
    }

    void FixedUpdate()
    {
        Throw();
    }

    public void readInput()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _jump = true;
        }
    }

    public void Throw()
    {
        if (_jump)
        {
            rb.AddForce(new Vector3(10, 10, 0) * throwForce);
            _jump = false;
        }
    }
}
