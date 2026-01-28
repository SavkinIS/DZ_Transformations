using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDirection : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Vector3 _moveDirection;
    private float _startPositionX;
    private float _endPositionX;

    private void Start()
    {
        _startPositionX =  transform.position.x;
        _endPositionX = Mathf.Abs(transform.position.x);
        _moveDirection = Vector3.right;
    }


    private void Update()
    {
        if (_moveDirection == Vector3.right && transform.position.x >= _endPositionX)
        {
            _moveDirection =  Vector3.left;
            
        }
        else if (_moveDirection == Vector3.left && transform.position.x < _startPositionX)
        {
            _moveDirection =  Vector3.right;
        }
            
        Vector3 moveDirection  = _moveDirection * _moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection);
        
    }
}
