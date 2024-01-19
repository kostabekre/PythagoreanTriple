using Core.Values;
using UnityEngine;
using UnityEngine.Events;

public class BooleanValueSubscriber : MonoBehaviour
{
    [SerializeField] private BooleanValue _bool;
    [SerializeField] private UnityEvent _on;
    [SerializeField] private UnityEvent _off;

    private void OnEnable()
    {
        _bool.OnValueChanged += InvokeEvent;
    }
    private void OnDisable()
    {
        _bool.OnValueChanged -= InvokeEvent;
    }

    private void InvokeEvent(bool value)
    {
        if(value)
        {
            _on.Invoke();
        }
        else
        {
            _off.Invoke();
        }
    }
}
