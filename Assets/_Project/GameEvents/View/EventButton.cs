using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class EventButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameEvent _event;

    private void OnEnable()
    {
        _button.onClick.AddListener(Invoke);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Invoke);
    }

    private void Invoke()
    {
        _event.Invoke();
    }

#if UNITY_EDITOR

    private void OnValidate()
    {
        if (_button == null)
        {
            _button = GetComponent<Button>();
        }
    }

#endif
}