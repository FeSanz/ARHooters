using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehaviour : MonoBehaviour
{
    [SerializeField, Tooltip("Velocidad de rotacion")]
    private float speed = 20.0f;

    void Update()
    {
        transform.Rotate( Vector3.up ,  speed * Time.deltaTime );
    }
}
