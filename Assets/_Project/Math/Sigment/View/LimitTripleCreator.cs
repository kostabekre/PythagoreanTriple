using Core.Values;
using Math.PythagoreanTriple;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace View.SigmentSystem
{
    public class LimitTripleCreator : MonoBehaviour
    {
        [SerializeField] private IntValue _index;
        [SerializeField] private IntValue _value;
        [SerializeField] private UnityEvent<Triple> _created;
        [SerializeField] private UnityEvent _notCreated;
        private Triple[] _triples;

        private void OnEnable()
        {
            _index.Changed += SendTriple;
        }
        private void OnDisable()
        {
            _index.Changed -= SendTriple;
        }

        private void SendTriple(int arg0)
        {
            _created?.Invoke(_triples[arg0]);
        }

        public void Create()
        {
            _triples = TripleCreator.LoopInLimit(_value);
            _index.Min = 0;
            _index.Max = _triples.Length;
            _index.Value = 0;
            if(_triples.Length > 0 )
            {
                _created?.Invoke(_triples[_index]);
            }
            else
            {
                _notCreated?.Invoke();
            }
        }
    }
}