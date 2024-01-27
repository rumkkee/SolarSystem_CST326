using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float yawRotationPerSecond;

    void Update()
    {
        transform.Rotate(new Vector3(0f, yawRotationPerSecond * Time.deltaTime, 0f), Space.World);
    }
}
