using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float _speed = 1f;

    private void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*_speed);
    }
}
