using TMPro;
using UnityEngine;

namespace Hints
{
    [ExecuteAlways]
    public class HintPanel : MonoBehaviour
    {
        [SerializeField] private HintInfo _info;
        [SerializeField] private HintInfo _default;
        [SerializeField] private TextMeshProUGUI _label;
        [SerializeField] private float _defaultFontSize = 30;

        private void OnEnable()
        {
            UpdateInfo();
        }
        public void SetInfo(HintInfo info)
        {
            _info = info;
            UpdateInfo();
        }
        public void Reset()
        {
            _info = null;
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            HintInfo info = _info == null ? _default : _info;
            _label.text = info.Value;
            if(info.UseCustomSize)
            {
                _label.fontSize = info.Size;
            }
            else
            {
                _label.fontSize = _defaultFontSize;
            }
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            UpdateInfo();
        }
#endif
    }
}