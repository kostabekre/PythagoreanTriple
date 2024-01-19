using System;
using UnityEngine;

namespace Core.Values
{
    [CreateAssetMenu(fileName = "BooleanValue", menuName = "Values/Boolean")]
    public class BooleanValue : ScriptableObject
    {
        [SerializeField] private bool _value;

        public event Action<bool> OnValueChanged;

        private void OnValidate()
        {
            OnValueChanged?.Invoke(_value);
        }

        public bool Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnValueChanged?.Invoke(value);
            }
        }
    }
}