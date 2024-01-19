using UnityEngine;

public class LineUnit : MonoBehaviour
{
    [SerializeField] private GameObject _unit_PREFAB;
    [SerializeField] private Transform _unitsSpawn;
    [SerializeField] private Transform _line;

    private void OnValidate()
    {
        ValidateOnlyTransform();
    }

    public int Length
    {
        get => (int)_line.localScale.x;
        set
        {
            _line.transform.localScale = new Vector3(value, _line.transform.localScale.y, _line.transform.localScale.z);
            ValidateOnlyTransform();
        }
    }

    private void ValidateOnlyTransform()
    {
        if (_line == null) return;

        if (_line.localScale.x < 2)
        {
            _line.localScale = new Vector3(2, _line.localScale.y, _line.localScale.z);
        }
        float x = Mathf.RoundToInt(_line.localScale.x);
        if (x % 2 == 1)
        {
            x = x - 1;
        }
        _line.localScale = new Vector3(x, _line.localScale.y, _line.localScale.z);
    }

    public void Validate()
    {
        ValidateOnlyTransform();
        if (_unit_PREFAB == null || _unitsSpawn == null || _line == null)
        {
            Debug.LogError("You have null fields!", transform);
            return;
        }
        ClearChildren();
        CreateUnits();
    }

    private void CreateUnits()
    {
        int xLength = (int)_line.localScale.x / 2;
        for (int i = -(xLength); i <= xLength; i++)
        {
            if (i == 0)
            {
                continue;
            }
            var unit = Instantiate(_unit_PREFAB, new Vector3(i, 0, 0), Quaternion.identity);
            unit.transform.SetParent(_unitsSpawn, false);
        }
    }

    private void ClearChildren()
    {
        for (int i = _unitsSpawn.childCount - 1; i >= 0; i--)
        {
            var child = _unitsSpawn.GetChild(i);
            if (Application.isPlaying)
            {
                Destroy(child.gameObject);
            }
            else
            {
                DestroyImmediate(child.gameObject);
            }
        }
    }
}