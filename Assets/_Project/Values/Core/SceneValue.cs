using UnityEngine;

namespace Core.Values
{
    [CreateAssetMenu(fileName = "SceneValue", menuName = "Values/Scene")]
    public class SceneValue : ScriptableObject
    {
        [SerializeField] private string _name;

        public string Value => _name;
    }
}