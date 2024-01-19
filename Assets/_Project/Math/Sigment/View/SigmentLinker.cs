using Math.SigmentSystem;
using UnityEngine;
using UnityEngine.Events;

namespace View.SigmentSystem
{
    public class SigmentLinker : MonoBehaviour
    {
        [SerializeField] private Sigment _sigment;
        [SerializeField] private UnityEvent<Sigment> _sigmentSet;

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (_sigment != null)
            {
                _sigmentSet?.Invoke(_sigment);
            }
        }

#endif
    }
}