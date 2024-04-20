using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    // Start is called before the first frame update
    public static  Vector3 GetRandomVector3Between (Vector3 min, Vector3 max)
    {
        return min + Random.Range (0f, 1f) * (max - min);
    }
}
