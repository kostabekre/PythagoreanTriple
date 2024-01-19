using Core.Values;
using Math.PythagoreanTriple;
using UnityEngine;
using UnityEngine.Events;

namespace View.SigmentSystem
{
    public class TripleValidation : MonoBehaviour
    {
        [SerializeField] private IntValue _aLength;
        [SerializeField] private IntValue _bLength;
        [SerializeField] private IntValue _cLength;

        [SerializeField] private UnityEvent _validated;
        [SerializeField] private UnityEvent _notValidated;

        public void Validate()
        {
            bool result  =TripleTools.IsTriple(_aLength, _bLength, _cLength);
            if(result)
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