using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private WheelJoint2D wheel;
    private JointMotor2D motor;

    public float speed;

    private void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
        motor = wheel.motor;
    }

    private void FixedUpdate()
    {
        float hForce = Input.GetAxis("Horizontal");
        motor.motorSpeed = speed * hForce;
        wheel.motor = motor;
    }
}