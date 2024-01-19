using Core.Values;
using UnityEngine;

namespace View.Values
{
    public class IntAdd : MonoBehaviour
    {
        [SerializeField] private IntValue _value;
        [SerializeField] private int _added = 1;

        public void Add()
        {
            _value.Value += _added;
        }
    }
}