using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Dino : MonoBehaviour
{
    private float _velocity;
    private float _xVelocity;
    
    public bool IsEjected;
    
    [SerializeField] private float spaceSurvivability = 3f;
    [SerializeField] private float ejectSpeed = 5.0f;
    [SerializeField] private float ejectRotationSpeed = 1.5f;
    [SerializeField] private float ejectScalingSpeed = 1.5f;
    
    [SerializeField] private Transform ejectedParent;

    private float _survivabilityTimer = 0.0f;
    private Vector3 _ejectDirection;
    private Transform _parent;
    
    private Vector3 localPosition;
    private Quaternion localRotation;
    private Vector3 position;
    private Quaternion rotation;
    private Vector3 localScale;
    
    private void Awake()
    {
        IsEjected = false;
    }

    public void Resurrect()
    {
        // IsEjected = false;
        //
        // transform.localPosition = localPosition;
        // transform.localRotation = localRotation;
        // transform.position = position;
        // transform.rotation = rotation;
        // transform.localScale = localScale;
        //
        // transform.SetParent(_parent, true);
        // gameObject.SetActive(true);
    }


    public void EjectIntoSpace()
    {
        // IsEjected = true;
        //
        // localPosition = transform.localPosition;
        // localRotation = transform.localRotation;
        // position = transform.position;
        // rotation = transform.rotation;
        // localScale = transform.localScale;
        //
        // _parent = gameObject.transform.parent;
        //
        // transform.SetParent(ejectedParent, false);
        //
        // _ejectDirection = Random.insideUnitSphere;
        // _ejectDirection.y = 0.0f;
        // _ejectDirection = _ejectDirection.normalized;
    }

    private void Update()
    {
        if (!IsEjected) return;
        
        transform.position += _ejectDirection * (ejectSpeed * Time.deltaTime);
        //transform.rotation = Quaternion.Euler(ejectSpeed * Time.deltaTime, 0, 0);
        // transform.localScale = Quaternion.Euler(ejectSpeed * Time.deltaTime, 0, 0);
            
        _survivabilityTimer += Time.deltaTime;
        if (_survivabilityTimer >= spaceSurvivability)
        {
            gameObject.SetActive(false);
        }
    }
}
