using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamGenerator : MonoBehaviour
{

    private Vector3 _leftUpCorner;
    private Vector3 _leftDownCorner;
    private Vector3 _rightUpCorner;
    private Vector3 _rightDownCorner;

    private enum Sides
    {
        LeftUp,
        LeftDown,
        RightUp,
        RightDown
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
