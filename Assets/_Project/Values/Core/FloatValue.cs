using UnityEngine;
using UnityEngine.Events;

namespace Core.Values
{
    [CreateAssetMenu(fileName = "Float", menuName = "Values/Float")]
    public class FloatValue : ScriptableObject
    {
        [SerializeField] private float _value;
        [SerializeField] private bool _isReadonly;
        [SerializeField] private UnityEvent<float> _changed;
        [SerializeField] private bool _useDefault;
        [SerializeField] private float _default;
        [SerializeField] private bool _useLimit;
        [SerializeField] private float _min;
        [SerializeField] private float _max;

        public static implicit operator float(FloatValue value) => value.Value;

        public event UnityAction<float> Changed
        {
            add => _changed.AddListener(value);
            remove => _changed.RemoveListener(value);
        }

        private float _oldValue;
        public float Default => _default;

        public float Value
        {
            get => _value;
            set
            {
                if (_isReadonly)
                {
                    return;
                }
                if(_useLimit)
                {
                    value = Mathf.Clamp(value, _min, _max);
                }
                _value = value;
                if (_oldValue != value)
                {
                    _changed?.Invoke(value);
                }
                _oldValue = _value;
            }
        }

        private void OnEnable()
        {
            if (_useDefault)
            {
                _value = _default;
            }
            _oldValue = _value;
        }

#if UNITY_EDITOR

        private void OnValidate()
        {
            if(_useLimit)
            {
                _value = Mathf.Clamp(_value,  _min, _max);
            }
            if (_oldValue != _value)
            {
                _oldValue = _value;
                _changed?.Invoke(_value);
            }
        }

#endif
    }
}