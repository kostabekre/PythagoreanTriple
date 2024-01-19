using Core.Values;
using TMPro;
using UnityEngine;

public class InputFieldsToVector : MonoBehaviour
{
    [SerializeField] private Vector3Value _value;
    [SerializeField] private TMP_InputField _fieldX;
    [SerializeField] private TMP_InputField _fieldY;


    private void OnEnable()
    {
        _fieldX.onValueChanged.AddListener(SetValueX);
        _fieldY.onValueChanged.AddListener(SetValueY);
    }


    private void OnDisable()
    {
        _fieldX.onValueChanged.RemoveListener(SetValueX);
        _fieldY.onValueChanged.RemoveListener(SetValueY);
        
    }

    private void SetValueY(string arg0)
    {
        bool parsed = float.TryParse(arg0, out float newNumber);
        if (parsed)
        {
            _value.Value = new Vector3(_value.Value.x, newNumber, _value.Value.z);
        }
        else
        {
            Debug.LogWarning("Could't parse input!", transform);
        }
    }

    private void SetValueX(string arg0)
    {
        bool parsed = float.TryParse(arg0, out float newNumber);
        if (parsed)
        {
            _value.Value = new Vector3(newNumber, _value.Value.y, _value.Value.z);
        }
        else
        {
            Debug.LogWarning("Could't parse input!", transform);
        }
    }
}
