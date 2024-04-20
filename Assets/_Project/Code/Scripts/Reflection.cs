using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var beam = collision.collider.GetComponent<RayBeam>();
        if (beam != null)
        {
            Vector3 beamDirection = beam.transform.forward; //d
            var contactPoint = collision.GetContact(0).point;

            float angle = Vector3.Angle(beamDirection, transform.forward);
            
            Debug.Log(beamDirection);

            Vector3 finaldirection = beamDirection - 2 * (Vector3.Dot(beamDirection,transform.forward)) * transform.forward;
            Debug.Log(finaldirection);
            beam.transform.forward = finaldirection;
            Destroy(gameObject);
        }
    }
}
