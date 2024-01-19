using Core.Values;
using UnityEngine;
using UnityEngine.Events;

public class LimitIndexButton : MonoBehaviour
{
    [SerializeField] private IntValue _index;
    [SerializeField] private bool _left;
    [SerializeField] private UnityEvent _onDisable;
    [SerializeField] private UnityEvent _onEnable;

    private void OnEnable()
    {
        _index.Changed += CheckButton;
        CheckButton(_index.Value);
    }

    private void OnDisable()
    {
        _index.Changed -= CheckButton;
    }

    private void CheckButton(int arg0)
    {
        if (_left)
        {
            if (_index == 0)
            {
                _onDisable.Invoke();
            }
            else
            {
                _onEnable.Invoke();
            }
        }
        else
        {
            if(_index == _index.Max - 1 || _index.Max <= 1)
            {
                _onDisable?.Invoke();
            }
            else
            {
                _onEnable?.Invoke();
            }
        }
    }
}