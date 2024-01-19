using Core.Values;
using UnityEngine;

namespace View.Values
{
    public class FloatAdd : MonoBehaviour
    {
        [SerializeField] private FloatValue _value;
        [SerializeField] private float _added = 1;

        public void Add()
        {
            _value.Value += _added;
        }
    }
}