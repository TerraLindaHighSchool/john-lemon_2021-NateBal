using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    private float currentPosition;
    void Start()
    {
        currentPosition = transform.rotation.y;
    }

    
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Rotate(45, currentPosition + 90, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(45, currentPosition - 90, 0);
        }
    }
}
