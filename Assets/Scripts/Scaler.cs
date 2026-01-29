using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [Range(0.1f, 0.5f)] [SerializeField] private float _resizeSpeed = 0.1f;
    
    private void Update()
    {
        transform.localScale = transform.localScale + (Vector3.one * _resizeSpeed * Time.deltaTime);
    }
}