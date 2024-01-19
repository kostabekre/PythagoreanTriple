using UnityEngine;

namespace UI.Tabs
{
    [ExecuteAlways]
    public class Tab : MonoBehaviour
    {
        [SerializeField] private TabPanel _panel;

        [ContextMenu("Enable")]
        public void Enable()
        {
            _panel.DeactivateTabs();

            gameObject.SetActive(true);
        }

#if UNITY_EDITOR

        private void OnValidate()
        {
            if (transform.parent != null)
            {
                _panel = transform.parent.GetComponent<TabPanel>();
            }
        }

#endif
    }
}