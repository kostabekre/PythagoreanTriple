using Core.Values;
using System;
using UnityEngine;

namespace Math.Space
{
    [ExecuteAlways]
    public class TransformOffset : MonoBehaviour
    {
        [SerializeField] private FloatValue _value;
        [SerializeField] private bool _x;
        [SerializeField] private bool _y;
        [SerializeField] private bool _z;

        private void OnEnable()
        {
            _value.Changed += UpdateTransform;
            UpdateTransform();
        }


        private void OnDisable()
        {
            _value.Changed -= UpdateTransform;
        }

        private void UpdateTransform()
        {
            if (_x && _y && _z)
            {
                transform.localPosition = new Vector3(_value,
                    _value,
                    _value);
            }
            else if (_x && _y)
            {
                transform.localPosition = new Vector3(_value,
                    _value);
            }
            else if (_x && _z)
            {
                transform.localPosition = new Vector3(_value,
                    0,
                    _value);
            }
            else if (_y && _z)
            {
                transform.localPosition = new Vector3(0,
                    _value,
                    _value);
            }
            else if(_x)
            {
                transform.localPosition = new Vector3(_value,
                    0);
            }
            else if(_y)
            {
                transform.localPosition = new Vector3(0,
                    _value);
            }
            else if(_z)
            {
                transform.localPosition = new Vector3(0,
                    0,
                    _value);
            }
        }

        private void UpdateTransform(float newValue)
        {
            UpdateTransform();
        }
    }
}