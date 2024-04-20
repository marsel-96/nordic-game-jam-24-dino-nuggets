using UnityEngine;



public class Orbits : MonoBehaviour
{
    private float _velocity;

    private void Awake()
    {
        _velocity = Random.Range(5f, 15f);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, _velocity *Time.deltaTime);
    }
}
