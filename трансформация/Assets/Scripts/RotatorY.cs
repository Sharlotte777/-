using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAlongY : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
