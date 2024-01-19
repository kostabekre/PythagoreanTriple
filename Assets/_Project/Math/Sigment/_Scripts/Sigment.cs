using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Math.SigmentSystem
{
    [CreateAssetMenu(fileName = "Sigment", menuName = "Math/Sigment")]
    public class Sigment : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private Color _color = Color.white;
        [SerializeField] private Material _material;
        [SerializeField] private Vector3 _start;
        [SerializeField] private Vector3 _end;

        public event Action<Sigment, SigmentChangedArgs> Changed;
        public string Name => _name;
        public Color Color => _color;
        public Material Material => _material;
        public float Length => Vector3.Distance(Start, End);
        public Vector3 Start
        {
            get { return _start; }
            set
            {
                Vector3 old = _start;
                _start = value;
                Changed?.Invoke(this, new SigmentChangedArgs(old, End));
            }
        }
        public Vector3 End
        {
            get { return _end; }
            set
            {
                Vector3 old = _end;
                _end = value;
                Changed?.Invoke(this, new SigmentChangedArgs(Start, old));
            }
        }
        public void ChangeValues(Vector3 start, Vector3 end)
        {
            Vector3 oldStart = Start;
            Vector3 oldEnd = End;
            _start = start;
            _end = end;
            Changed?.Invoke(this, new SigmentChangedArgs(oldStart, oldEnd));
        }

#if UNITY_EDITOR

        private void OnValidate()
        {
            Changed?.Invoke(this, new SigmentChangedArgs(_start, _end));
        }
#endif
    }
}