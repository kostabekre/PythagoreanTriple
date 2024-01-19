using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnUIElementDisable : MonoBehaviour
{
    [SerializeField] private UnityEvent _disabled;

    private void OnDisable()
    {
        _disabled?.Invoke();
    }
}
