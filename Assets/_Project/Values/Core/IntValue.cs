using UnityEngine;
using UnityEngine.Events;

namespace Core.Values
{
    [CreateAssetMenu(fileName = "Int", menuName = "Values/Int")]
    public class IntValue : ScriptableObject
    {
        [SerializeField] private int _value;
        [SerializeField] private bool _useClamp;
        [SerializeField] private int _min;
        [SerializeField] private int _max;
        [SerializeField] private bool _useDefault;
        [SerializeField] private int _default;
        [SerializeField] private int _defaultMin;
        [SerializeField] private int _defaultMax = 1;
        [SerializeField] private bool _readonly;
        public int Old { get; private set; }
        [SerializeField] private UnityEvent<int> _changed;

        public event UnityAction<int> Changed
        {
            add => _changed.AddListener(value);
            remove => _changed.RemoveListener(value);
        }
        public static implicit operator int(IntValue value) => value.Value;

        public int Min
        {
            get => _min;
            set => _min = value;
        }
        public int Max
        {
            get => _max;
            set => _max = value;
        }
        public int Value
        {
            get => _value;
            set
            {
                if(_readonly)
                {
                    Debug.LogWarning("Int is readonly!", this);
                    return;
                }
                if(_useClamp)
                {
                    value = Mathf.Clamp(value, _min, _max);
                }
                Old  = _value;   
                _value = value;
                _changed?.Invoke(value);
            }
        }

        private void OnEnable()
        {
            if(_useDefault)
            {
                _value = _default;
                _min = _defaultMin;
                _max = _defaultMax;
                Old = _value;
            }
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if(_useClamp)
            {
                _value = (int)Mathf.Clamp(_value, _min, _max);
            }
            if(Old != _value)
            {
                Old = _value;
                _changed?.Invoke(_value);
            }
        }
#endif
    }
}