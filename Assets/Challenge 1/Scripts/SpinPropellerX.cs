using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    float propellerRotationSpeed = 60;

    void Update()
    {
        transform.Rotate(0, 0, 30 * Time.deltaTime * propellerRotationSpeed);
    }
}
