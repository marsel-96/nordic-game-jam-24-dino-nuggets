using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BeamGenerator : MonoBehaviour
{

    private Vector3 _leftUpCorner;
    private Vector3 _leftDownCorner;
    private Vector3 _rightUpCorner;
    private Vector3 _rightDownCorner;

    public GameObject beam;

    private enum Sides
    {
        LeftUp,
        LeftDown,
        RightUp,
        RightDown
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(beam,new Vector3(0, 5, -8), Quaternion.identity);
        }
    }

    private void SpawnBeam()
    {
        var side = (Sides)Random.Range(0, 4);

        switch (side)
        {
            case Sides.LeftUp:
                
                break;
            case Sides.LeftDown:
                break;
            case Sides.RightUp:
                break;
            case Sides.RightDown:
                break;
            default:
                break;
        } 
    }
    
}
