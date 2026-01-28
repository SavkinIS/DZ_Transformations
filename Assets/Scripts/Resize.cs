using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    [Range(0.1f, 0.5f)] [SerializeField] private float _resizeSpeed = 0.1f;
    [SerializeField] private float _sizeMinValue = 0.3f;
    [SerializeField] private float _sizeMaxValue = 2f;
    
    private Vector3 _sizeMax;
    private Vector3 _sizeMin;
    private float _resizeRate;

    private void Start()
    {
        _sizeMin = Vector3.one * _sizeMinValue;
        _sizeMax = Vector3.one * _sizeMaxValue;
        _resizeRate = _resizeSpeed;
    }

    private void Update()
    {
        if (transform.localScale.IsHigherThan(_sizeMax))
        {
            _resizeRate = _resizeSpeed * -1;
        }
        else if (transform.localScale.IsLowerThan(_sizeMin))
        {
            _resizeRate = _resizeSpeed;
        }

        transform.localScale = transform.localScale + (Vector3.one * _resizeRate * Time.deltaTime);
    }
}