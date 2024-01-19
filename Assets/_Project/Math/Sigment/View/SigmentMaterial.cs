using Math.SigmentSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View.SigmentSystem
{
    [ExecuteInEditMode]
    public class SigmentMaterial : MonoBehaviour
    {
        [SerializeField] private Sigment _sigment;
        [SerializeField] private MeshRenderer _renderer;

        public void Init(Sigment sigment)
        {
            _sigment = sigment;
        }

        private void OnEnable()
        {
            _sigment.Changed += UpdateMaterial;
            UpdateMaterial();
        }
        private void OnDisable()
        {
            _sigment.Changed -= UpdateMaterial;
        }

        private void UpdateMaterial(Sigment sigment, SigmentChangedArgs args)
        {
            UpdateMaterial();
        }

        private void UpdateMaterial()
        {
            _renderer.sharedMaterial = _sigment.Material;
        }
    }
}
