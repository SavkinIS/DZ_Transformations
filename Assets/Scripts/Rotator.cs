using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Vector3 _rotationDirection;

    private void Update()
    {
        Vector3 rotationDirection = _rotationDirection * _rotationSpeed * Time.deltaTime;
        transform.Rotate(rotationDirection);
    }
}
