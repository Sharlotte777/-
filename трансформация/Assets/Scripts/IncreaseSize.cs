using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _maxScaleOffset = 1.0f;
    private float _originalScale;

    private void Start()
    {
        _originalScale = transform.localScale.y;
    }

    private void Update()
    {
        transform.localScale = Vector3.one * (_originalScale + _maxScaleOffset * _speed * Time.deltaTime);
    }
}
