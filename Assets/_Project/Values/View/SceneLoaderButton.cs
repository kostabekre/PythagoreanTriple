using UnityEngine;
using UnityEngine.UI;

namespace View.Values
{
    [RequireComponent(typeof(SceneLoader))]
    [RequireComponent(typeof(Button))]
    public class SceneLoaderButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private SceneLoader _loader;

        private void OnEnable()
        {
            _button.onClick.AddListener(Load);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(Load);
        }

        private void Load()
        {
            _loader.Load();
        }

#if UNITY_EDITOR

        private void OnValidate()
        {
            if (_loader == null)
            {
                _loader = GetComponent<SceneLoader>();
            }
            if (_button == null)
            {
                _button = GetComponent<Button>();
            }
        }

#endif
    }
}