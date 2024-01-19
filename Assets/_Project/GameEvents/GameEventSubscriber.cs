using UnityEngine;
using UnityEngine.Events;

public class GameEventSubscriber : MonoBehaviour
{
    [SerializeField] private GameEvent _gameEvent;
    [SerializeField] private UnityEvent _eventInvoked;
    private void OnEnable()
    {
        _gameEvent.Add(this);
    }
    private void OnDisable()
    {
        _gameEvent.Remove(this);
    }
    internal void EventInvoked()
    {
        _eventInvoked?.Invoke();
    }
}
