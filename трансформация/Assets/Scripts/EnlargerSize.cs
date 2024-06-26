using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargerSize : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _maxScaleOffset = 0.001f;

    private void Update()
    {
        transform.localScale += Vector3.one * (_maxScaleOffset * _speed * Time.time);
    }
}
