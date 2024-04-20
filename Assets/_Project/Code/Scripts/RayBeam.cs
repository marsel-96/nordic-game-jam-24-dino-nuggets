using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayBeam : MonoBehaviour
{
    [SerializeField] private float velocity = 5.0f;

    // Start is called before the first frame update

    private void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
    }
}
