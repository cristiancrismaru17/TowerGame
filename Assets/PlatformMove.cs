using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float accel = 0.001f;
    public const float maxVelocity = 0.05f;
    public float Speed = 0f;
    float velocity = 0f;

    // Update is called once per frame
    void Update()
    {
        if (velocity + accel >= maxVelocity)
        {
            velocity = maxVelocity;
            accel = 0f;
        }
        else
        {
            velocity += accel * Time.deltaTime;
        }
        transform.Translate(0, velocity, 0);
    }
}
