using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class SoundButton : MonoBehaviour
{
    [SerializeField] private Sound _sound;
    [SerializeField] private Button _button;
    [SerializeField] private ImmortalAudioSource _audioSource;

    private void OnEnable()
    {
        _button.onClick.AddListener(PlaySound);
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlaySound);  
    }

    private void PlaySound()
    {
        _sound.Play(_audioSource);
    }


#if UNITY_EDITOR
    private void OnValidate()
    {
        if(_button == null)
        {
            _button = GetComponent<Button>();
        }
    }
#endif
}
