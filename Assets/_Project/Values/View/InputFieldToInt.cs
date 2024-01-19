using Core.Values;
using System;
using TMPro;
using UnityEngine;
public class InputFieldToInt : MonoBehaviour
{
    [SerializeField] private IntValue _value;
    [SerializeField] private TMP_InputField _field;

    private void OnEnable()
    {
        _field.onValueChanged.AddListener(SetValue);
    }
    private void OnDisable()
    {
        _field.onValueChanged.RemoveListener(SetValue);
        
    }

    private void SetValue(string text)
    {
        bool parsed = Int32.TryParse(_field.text, out int value);
        if (parsed)
        {
            _value.Value = value;
        }
        else
        {
            Debug.LogWarning("Could't parse input!", transform);
        }
    }
}