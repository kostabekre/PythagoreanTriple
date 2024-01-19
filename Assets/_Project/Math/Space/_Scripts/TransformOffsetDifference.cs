using Core.Values;
using UnityEngine;

namespace Math.Space
{
    [ExecuteAlways]
    public class TransformOffsetDifference : MonoBehaviour
    {
        [SerializeField] private FloatValue _value;
        [SerializeField] private bool _x;
        [SerializeField] private bool _y;
        [SerializeField] private bool _z;
        private float _oldValue;

        private void OnEnable()
        {
            _value.Changed += OnChanged;

        }

        private void OnDisable()
        {
            _value.Changed -= OnChanged;
        }

        private void OnChanged(float newValue)
        {
            UpdateTransform(newValue - _oldValue);
            _oldValue = newValue;
        }

        private void UpdateTransform(float difference)
        {
            if (_x && _y && _z)
            {
                transform.localPosition += new Vector3(difference,
                    difference,
                    difference);
            }
            else if (_x && _y)
            {
                transform.localPosition += new Vector3(difference,
                    difference);
            }
            else if (_x && _z)
            {
                transform.localPosition += new Vector3(difference,
                    0,
                    difference);
            }
            else if (_y && _z)
            {
                transform.localPosition += new Vector3(0,
                    difference,
                    difference);
            }
            else if(_x)
            {
                transform.localPosition += new Vector3(difference,
                    0);
            }
            else if(_y)
            {
                transform.localPosition += new Vector3(0,
                    difference);
            }
            else if(_z)
            {
                transform.localPosition += new Vector3(0,
                    0,
                    difference);
            }
        }
    }
}