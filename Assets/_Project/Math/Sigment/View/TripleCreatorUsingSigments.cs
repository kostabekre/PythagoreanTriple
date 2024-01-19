using Math.PythagoreanTriple;
using Math.SigmentSystem;
using UnityEngine;

namespace View.SigmentSystem
{
    public class TripleCreatorUsingSigments : MonoBehaviour
    {
        [SerializeField] private Sigment _a;
        [SerializeField] private Sigment _b;
        [SerializeField] private Sigment _c;

        public void Create(Triple triple)
        {
            _a.Start = Vector3.zero;
            _a.End = new Vector3(triple.A, 0, 0);
            _b.Start = Vector3.zero;
            _b.End = new Vector3(0, triple.B, 0);
            _c.Start = _a.End;
            _c.End = _b.End;
        }
    }
}