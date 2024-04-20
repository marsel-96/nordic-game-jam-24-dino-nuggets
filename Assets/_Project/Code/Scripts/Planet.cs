using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private float _xVelocity;
    private float _yVelocity;
    private float _zVelocity;
    void Start()
    {
        _xVelocity = Random.Range(1f, 9f);
        _yVelocity = Random.Range(1f, 9f);
        _zVelocity = Random.Range(1f, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_xVelocity*Time.deltaTime, _yVelocity*Time.deltaTime,_zVelocity*Time.deltaTime);
    }
}
