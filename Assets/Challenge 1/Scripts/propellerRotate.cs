using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerRotate : MonoBehaviour
{
    void LateUpdate()
    {
        transform.Rotate(0,0,10);
    }
}
