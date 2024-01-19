using Math.SigmentSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View.SigmentSystem
{
    [ExecuteInEditMode]
    public class SigmentArrow : MonoBehaviour
    {
        [SerializeField] private Sigment _sigment;

        public void Init(Sigment sigment)
        {
            _sigment = sigment;
        }
        private void OnEnable()
        {
            _sigment.Changed += UpdatePosition;
            UpdatePosition();
        }
        private void OnDisable()
        {
            _sigment.Changed -= UpdatePosition;
        }

        private void UpdatePosition(Sigment sigment, SigmentChangedArgs args)
        {
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            transform.localPosition = new Vector3(0, 0, _sigment.Length);
        }
    }
}
