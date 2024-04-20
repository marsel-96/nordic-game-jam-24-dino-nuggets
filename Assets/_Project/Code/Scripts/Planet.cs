using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private float _xVelocity;
    private float _yVelocity;
    private float _zVelocity;
    

    public bool isMeteorito;
    private void Start()
    {
        _xVelocity = Random.Range(1f, 9f);
        _yVelocity = Random.Range(1f, 9f);
        _zVelocity = Random.Range(1f, 9f);
        if (isMeteorito)
        {
            _xVelocity *= 10;
            _yVelocity *= 10;
            _zVelocity *= 10;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(_xVelocity*Time.deltaTime, _yVelocity*Time.deltaTime,_zVelocity*Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        var beam = other.GetComponent<RayBeam>();
        // TODO Trigger damage effect
        Destroy(beam.gameObject);
    }
}
