using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.Tabs
{
    public class TabPanel : MonoBehaviour
    {
        [SerializeField] private bool _cache;
        private Transform[] _tabs;

        private void Awake()
        {
            if (_cache && Application.isPlaying)
            {
                GetTabs();
            }
        }

        private void GetTabs()
        {

            RectTransform rect = transform.GetComponent<RectTransform>();
            _tabs = new Transform[rect.childCount];

            for (int i = 0; i < rect.childCount; i++)
            {
                _tabs[i] = rect.GetChild(i);
            }
        }

        public void DeactivateTabs()
        {
            if (_cache == false || Application.isEditor)
            {
                GetTabs();
            }

            foreach (var child in _tabs)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
