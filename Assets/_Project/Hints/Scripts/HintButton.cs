using UnityEngine;
using UnityEngine.UI;

namespace Hints
{
    [RequireComponent(typeof(HintContainer))]
    [RequireComponent(typeof(Button))]
    public class HintButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private HintContainer _container;

        private void OnEnable()
        {
            _button.onClick.AddListener(SendEvent);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(SendEvent);
        }

        private void SendEvent()
        {
            _container.SetInfo();
        }

#if UNITY_EDITOR

        private void OnValidate()
        {
            if (_button == null)
            {
                _button = GetComponent<Button>();
            }
            if (_container == null)
            {
                _container = GetComponent<HintContainer>();
            }
        }

#endif
    }
}