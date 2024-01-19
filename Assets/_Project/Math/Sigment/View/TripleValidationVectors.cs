using Core.Values;
using Math.PythagoreanTriple;
using UnityEngine;
using UnityEngine.Events;

namespace View.SigmentSystem
{
    public class TripleValidationVectors : MonoBehaviour
    {
        [SerializeField] private Vector3Value _aStart;
        [SerializeField] private Vector3Value _aEnd;
        [SerializeField] private Vector3Value _bStart;
        [SerializeField] private Vector3Value _bEnd;
        [SerializeField] private Vector3Value _cStart;
        [SerializeField] private Vector3Value _cEnd;
        [SerializeField] private IntValue _aLength;
        [SerializeField] private IntValue _bLength;
        [SerializeField] private IntValue _cLength;

        [SerializeField] private UnityEvent _validated;
        [SerializeField] private UnityEvent _notValidated;

        private bool CheckValues()
        {
            float aLength = Vector3.Distance(_aStart, _aEnd);
            float bLength = Vector3.Distance(_bStart, _bEnd);
            float cLength = Vector3.Distance(_cStart, _cEnd);
            if((aLength % 1) != 0)
            {
                return false;
            }
            else if ((bLength % 1) != 0)
            {
                return false;
            }
            else if ((cLength % 1) != 0)
            {
                return false;
            }
            _aLength.Value = (int)aLength;
            _bLength.Value = (int)bLength;
            _cLength.Value = (int)cLength;
            return TripleTools.IsTriple(_aLength, _bLength, _cLength);
        }
        public void Validate()
        {
            bool result = CheckValues();
            if (result)
            {
                _validated?.Invoke();
            }
            else
            {
                _notValidated?.Invoke();
            }
        }
    }
}