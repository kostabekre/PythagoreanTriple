using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LineUnit))]
public class LineUnitEditor : Editor
{
    private LineUnit _target;

    private void Awake()
    {
        _target = (LineUnit)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Check"))
        {
            CheckLine();
        }
        int lengthBefore = _target.Length;
        EditorGUILayout.BeginHorizontal();

        GUILayout.Label("Length");
        _target.Length = EditorGUILayout.IntSlider(_target.Length, 2, 100);

        EditorGUILayout.EndHorizontal();
        if (lengthBefore != _target.Length)
        {
            CheckLine();
        }
    }

    private void CheckLine()
    {
        _target.Validate();
    }
}