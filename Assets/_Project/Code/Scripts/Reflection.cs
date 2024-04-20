using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    [SerializeField] private float lifeTime = 1.0f;
    
    private float _timeAlive;

    public bool infiniteTime;

    private void Update()
    {
        _timeAlive += Time.deltaTime;

        if (_timeAlive >= lifeTime && !infiniteTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var beam = collision.collider.GetComponent<RayBeam>();
        if (beam != null)
        {
            Vector3 beamDirection = beam.transform.forward;

            Vector3 finaldirection = beamDirection - 2 * (Vector3.Dot(beamDirection,transform.forward)) * transform.forward;
            //Debug.Log(finaldirection);
            finaldirection.y = 0;
            Vector3.Normalize(finaldirection);
            beam.transform.forward = finaldirection;
            beam.transform.position = collision.GetContact(0).point;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var beam = other.GetComponent<RayBeam>();
        if (beam != null)
        {
            Vector3 beamDirection = beam.transform.forward;
            Vector3 finaldirection = beamDirection - 2 * (Vector3.Dot(beamDirection,transform.forward)) * transform.forward;
            finaldirection.y = 0;
            Vector3.Normalize(finaldirection);
            beam.transform.forward = finaldirection;
            Destroy(gameObject);
        }
    }
}
