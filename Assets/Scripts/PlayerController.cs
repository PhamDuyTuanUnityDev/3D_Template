using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Move the vehicle forward
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
