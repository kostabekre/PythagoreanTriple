using UnityEngine;
using UnityEngine.Events;

namespace Hints
{
    public class HintContainer : MonoBehaviour
    {
        [SerializeField] private HintInfo _info;
        [SerializeField] private UnityEvent<HintInfo> _setInfo;

        public void SetInfo()
        {
            _setInfo?.Invoke(_info);
        }
    }
}