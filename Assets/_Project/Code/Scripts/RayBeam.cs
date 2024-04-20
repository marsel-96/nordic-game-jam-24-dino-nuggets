using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class RayBeam : MonoBehaviour
{

    private float _timeToSmoke;
    private float _prevSmoke;
    [SerializeField] private float velocity = 5.0f;
    [SerializeField] private GameObject particle;

    private void Awake()
    {
        velocity = Random.Range(4.0f, 7.0f);
        _timeToSmoke = Random.Range(0.3f, 1.0f);
    }

    private void Update()
    {
        Vector3 axis = transform.forward;
        //Debug.Log(axis + " and " + _rigidbody.velocity.normalized);
        axis.y = 0;
        Vector3.Normalize(axis);
        transform.position += axis * (velocity * Time.deltaTime);

        //Particle
        _prevSmoke += Time.deltaTime;
        if (!(_prevSmoke > _timeToSmoke)) return;
        
        _prevSmoke = Random.Range(0.3f, 1.0f);
        var p = Instantiate(particle, transform.position, Random.rotation);
        p.transform.localScale = Vector3.one * Random.Range(0.05f, 0.3f);
        Destroy(p, 2.0f);

    }
}
