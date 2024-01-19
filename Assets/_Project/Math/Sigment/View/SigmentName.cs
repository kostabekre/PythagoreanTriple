using Math.SigmentSystem;
using TMPro;
using UnityEngine;

namespace View.SigmentSystem
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(TextMeshPro))]
    public class SigmentName : MonoBehaviour
    {
        [SerializeField] private Sigment _sigment;
        [SerializeField] private TextMeshPro _label;

        public void Init(Sigment sigment)
        {
            _sigment = sigment;
        }

        private void OnEnable()
        {
            _sigment.Changed += UpdateLabel;
            UpdateLabel();
        }

        private void OnDisable()
        {
            _sigment.Changed -= UpdateLabel;
        }

        private void UpdateLabel()
        {
            _label.color = _sigment.Color;
            _label.text = _sigment.Name;
            _label.margin = new Vector4(0, 0, _sigment.Length - 1, 0);
        }

        private void UpdateLabel(Sigment sigment, SigmentChangedArgs args)
        {
            UpdateLabel();
        }
    }
}