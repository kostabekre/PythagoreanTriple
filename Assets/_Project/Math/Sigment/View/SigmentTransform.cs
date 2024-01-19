using Math.SigmentSystem;
using UnityEngine;

namespace View.SigmentSystem
{
    [ExecuteInEditMode]
    public class SigmentTransform : MonoBehaviour
    {
        [SerializeField] private Sigment _sigment;
        [SerializeField] private Transform _lineModel;
        [SerializeField] private GameObject _rotateTowards;

        public void Init(Sigment sigment)
        {
            _sigment = sigment;
        }

        private void OnEnable()
        {
            _sigment.Changed += UpdateLength;
            UpdateTransform();
        }

        private void OnDisable()
        {
            _sigment.Changed -= UpdateLength;
        }

        private void UpdateTransform()
        {
            transform.localPosition = _sigment.Start;
            _lineModel.localScale = new Vector3(1, 1, _sigment.Length);
            _rotateTowards.transform.localPosition = _sigment.End;
            //float yAngle = _sigment.End.x - _sigment.Start.x > 0 ? -90 : 90;
            //float xAngle = -(Mathf.Rad2Deg * (Mathf.Atan2(_sigment.End.y - _sigment.Start.y, _sigment.End.x - _sigment.Start.x)));
            transform.LookAt(_rotateTowards.transform.position);
            //transform.eulerAngles = new Vector3(xAngle, yAngle);
        }

        private void UpdateLength(Sigment sigment, SigmentChangedArgs args)
        {
            UpdateTransform();
        }
    }
}