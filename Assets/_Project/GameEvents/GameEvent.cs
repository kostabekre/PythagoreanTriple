using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameEvent", menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
    private List<GameEventSubscriber> _subscribers = new();
    internal void Add(GameEventSubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }
    internal void Remove(GameEventSubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }
    public void Invoke()
    {
        for (int i = _subscribers.Count - 1; i >= 0; i--)
        {
            GameEventSubscriber subscriber = _subscribers[i];
            subscriber.EventInvoked();
        }
    }
}
