using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    // Move the vehicle forward
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
