using UI.Tabs;
using UnityEditor;
using UnityEngine;

namespace EditorUI.Tabs
{
    [CustomEditor(typeof(Tab))]
    public class TabEditor : Editor
    {
        private Tab _target;

        private void Awake()
        {
            _target = (Tab)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Enable"))
            {
                _target.Enable();
            }
        }
    }
}