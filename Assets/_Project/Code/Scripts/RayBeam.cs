using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayBeam : MonoBehaviour
{
    private float _lifeTime = 10.0f;
    private float _timeAlive;
    
    [SerializeField] private float velocity = 5.0f;
    private void Update()
    {
        Vector3 axis = transform.forward;
        //Debug.Log(axis + " and " + _rigidbody.velocity.normalized);
        axis.y = 0;
        Vector3.Normalize(axis);
        transform.position += axis * (velocity * Time.deltaTime);

        _timeAlive += Time.deltaTime;
        if (_timeAlive > _lifeTime)
        {
            Destroy(gameObject);
        }

    }
}
