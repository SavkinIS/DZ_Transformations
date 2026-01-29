using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Vector3 _moveDirection;

    private void Update()
    { 
        Vector3 moveDirection  = _moveDirection * _moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection);
        
    }
}
