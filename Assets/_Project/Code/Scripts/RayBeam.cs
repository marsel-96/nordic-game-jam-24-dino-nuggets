using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RayBeam : MonoBehaviour
{
   
    
    [SerializeField] private float velocity = 5.0f;

    private void Awake()
    {
        velocity = Random.Range(4.0f, 7.0f);
    }

    private void Update()
    {
        Vector3 axis = transform.forward;
        //Debug.Log(axis + " and " + _rigidbody.velocity.normalized);
        axis.y = 0;
        Vector3.Normalize(axis);
        transform.position += axis * (velocity * Time.deltaTime);

    }
}
