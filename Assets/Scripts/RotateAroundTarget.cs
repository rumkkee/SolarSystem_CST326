using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget : MonoBehaviour
{
    [SerializeField] private float rotationPerSecond;

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, rotationPerSecond * Time.deltaTime);
        
    }
}
