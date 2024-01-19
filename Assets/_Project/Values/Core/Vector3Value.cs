using UnityEngine;
using UnityEngine.Events;

namespace Core.Values
{
    [CreateAssetMenu(fileName = "Vector3", menuName = "Values/Vector3")]
    public class Vector3Value : ScriptableObject
    {
        [SerializeField] private Vector3 _value;
        [SerializeField] private bool _isReadonly;
        [SerializeField] private UnityEvent<Vector3> _changed;
        [SerializeField] private bool _useDefault;
        [SerializeField] private Vector3 _default;
        [SerializeField] private bool _useLimit;
        [SerializeField] private Vector3 _min;
        [SerializeField] private Vector3 _max;

        public static implicit operator Vector3(Vector3Value value) => value.Value;

        public event UnityAction<Vector3> Changed
        {
            add => _changed.AddListener(value);
            remove => _changed.RemoveListener(value);
        }

        private Vector3 _oldValue;
        public Vector3 Default => _default;

        public Vector3 Value
        {
            get => _value;
            set
            {
                if (_isReadonly)
                {
                    return;
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
            if (_oldValue != _value)
            {
                _oldValue = _value;
                _changed?.Invoke(_value);
            }
        }

#endif
    }
}