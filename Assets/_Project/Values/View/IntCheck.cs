using Core.Values;
using UnityEngine;
using UnityEngine.Events;

public class IntCheck : MonoBehaviour
{
    [SerializeField] private IntValue _value;
    [SerializeField] private bool _useMin; 
    [SerializeField] private bool _useMax; 
    [SerializeField] private int _min;
    [SerializeField] private int _max;
    [SerializeField] private UnityEvent _onTrue;
    [SerializeField] private UnityEvent _onFalse;

    public void Validate()
    {
        if(_useMin)
        {
            if(_value < _min)
            {
                _onFalse?.Invoke();
                return;
            }
        }
        if(_useMax)
        {
            if(_value > _max)
            {
                _onFalse?.Invoke();
                return;
            }
        }
        _onTrue?.Invoke();
    }
}