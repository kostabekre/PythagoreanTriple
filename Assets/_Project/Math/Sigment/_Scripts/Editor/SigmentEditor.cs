using UnityEditor;

namespace Math.SigmentSystem
{
    [CustomEditor(typeof(Sigment))]
    public class SigmentEditor : Editor
    {
        private Sigment _target;

        private void Awake()
        {
            _target = (Sigment)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.LabelField($"Length {_target.Length}");
        }
    }
}