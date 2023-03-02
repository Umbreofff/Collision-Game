using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderObstacle : MonoBehaviour
{
    [SerializeField] private float rotationForce = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationForce * Time.deltaTime);
    }
}
