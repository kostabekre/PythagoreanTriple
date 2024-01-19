using Core.Values;
using Math.SigmentSystem;
using UnityEngine;

namespace View.SigmentSystem
{
    public class TripleBasedOnVectors : MonoBehaviour
    {
        [SerializeField] private Vector3Value _aVectorS;
        [SerializeField] private Vector3Value _aVectorE;
        [SerializeField] private Vector3Value _bVectorS;
        [SerializeField] private Vector3Value _bVectorE;
        [SerializeField] private Vector3Value _cVectorS;
        [SerializeField] private Vector3Value _cVectorE;
        [SerializeField] private Sigment _a;
        [SerializeField] private Sigment _b;
        [SerializeField] private Sigment _c;

        public void Create()
        {
            _a.Start = _aVectorS;
            _a.End = _aVectorE;
            _b.Start = _bVectorS;
            _b.End = _bVectorE;
            _c.Start = _cVectorS;
            _c.End = _cVectorE;
        }
    }
}