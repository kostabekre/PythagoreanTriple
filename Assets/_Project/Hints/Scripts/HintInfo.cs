using Core.Values;
using UnityEngine;

namespace Hints
{
    [CreateAssetMenu(fileName = "Hint", menuName = "Hints/Info")]
    public class HintInfo : StringValue
    {
        [SerializeField] private bool _useCustomSize;
        [SerializeField] private float _size;

        public bool UseCustomSize => _useCustomSize;
        public float Size => _size; 
    }
}