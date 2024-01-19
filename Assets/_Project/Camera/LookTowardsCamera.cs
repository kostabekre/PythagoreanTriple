using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowardsCamera : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private void Awake()
    {
        if (_camera == null )
        {
            _camera = Camera.main;
        }
    }
    private void LateUpdate()
    {
        transform.LookAt(transform.position);
    }
}
