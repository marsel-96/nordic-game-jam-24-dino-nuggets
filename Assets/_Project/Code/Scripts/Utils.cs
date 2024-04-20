using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Utils : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector3 GetRandomVector3Between (Vector3 min, Vector3 max)
    {
        return min + Random.Range (0f, 1f) * (max - min);
    }

    private const float TwoThird = (2 * Mathf.PI) / 3;

    public static float EaseOutElastic(float x)
    {
        return x == 0 ? 0 : Mathf.Approximately(x, 1) ? 1 : Mathf.Pow(2, -10 * x) * Mathf.Sin((x * 10 - 0.75f) * TwoThird) + 1;
    }
}
