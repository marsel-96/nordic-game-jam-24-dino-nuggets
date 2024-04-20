using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    private float _velocity;
    private float _xVelocity;

    private void Awake()
    {
        if (Random.Range(0,4) > 1)
        {
            Destroy(gameObject);
        }
        _velocity = Random.Range(5f, 15f);
        _xVelocity = Random.Range(-5f, 5f);
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, _velocity *Time.deltaTime);
        transform.Rotate(Vector3.right, _xVelocity *Time.deltaTime);
    }
}
