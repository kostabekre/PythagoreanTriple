using Core.Values;
using Math.SigmentSystem;
using UnityEngine;

namespace View.SigmentSystem
{
    public class TripleBasedOnLength : MonoBehaviour
    {
        [SerializeField] private IntValue _aLength;
        [SerializeField] private IntValue _bLength;
        [SerializeField] private IntValue _cLength;
        [SerializeField] private Sigment _a;
        [SerializeField] private Sigment _b;
        [SerializeField] private Sigment _c;

        public void Create()
        {
            _a.Start = Vector3.zero;
            _a.End = new Vector3(_aLength, 0, 0);
            _b.Start = Vector3.zero;
            _b.End = new Vector3(0, _bLength, 0);
            _c.Start = _a.End;
            _c.End = _b.End;
        }
    }
}