using UnityEngine;
using UnityEngine.Events;

public class OnUIElementEnable : MonoBehaviour
{
    [SerializeField] private UnityEvent _enabled;

    private void OnEnable()
    {
        _enabled?.Invoke();
    }
}
