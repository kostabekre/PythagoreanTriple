using UnityEngine;
using UnityEngine.UI;

namespace UI.Tabs
{
    public class TabButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Tab _next;

        private void OnEnable()
        {
            _button.onClick.AddListener(SwitchTab);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(SwitchTab);
        }

        private void SwitchTab()
        {
            _next.Enable();
        }

#if UNITY_EDITOR

        private void OnValidate()
        {
            if (_button == null)
            {
                _button = GetComponent<Button>();
            }
        }

#endif
    }
}