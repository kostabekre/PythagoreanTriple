using UnityEngine;

namespace Core.Values
{
    [CreateAssetMenu(fileName = "StringValue", menuName = "Values/String")]
    public class StringValue : ScriptableObject
    {
        [TextArea(1, 5) ][SerializeField] private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}