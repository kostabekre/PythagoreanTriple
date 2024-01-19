using UnityEngine;
using UnityEngine.Events;

namespace Core.Values
{
    public class FloatValueSubscriber : MonoBehaviour
    {
        [SerializeField] private FloatValue _value;
        [SerializeField] private UnityEvent<float> _onValueChanged;

        private void OnEnable()
        {
            _value.Changed += ValueChanged;
        }
        private void OnDisable()
        {
            _value.Changed -= ValueChanged;
        }

        private void ValueChanged(float arg0)
        {
            _onValueChanged?.Invoke(arg0);
        }
    }
}