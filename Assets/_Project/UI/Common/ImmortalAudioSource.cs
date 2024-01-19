using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "AudioSource", menuName = "AudioSource")]
public class ImmortalAudioSource : ScriptableObject
{
    [SerializeField] private AudioMixerGroup _group;
    [SerializeField] private bool _doNotDestroy;
    private AudioSource _audioSource;
    public AudioSource AudioSource
    {
        get
        {
            if (_audioSource == null)
            {
                _audioSource = new GameObject(name).AddComponent<AudioSource>();
                _audioSource.hideFlags = HideFlags.DontSaveInEditor;
                GameObject.DontDestroyOnLoad(_audioSource);
            }
            return _audioSource;
        }
    }

    public static implicit operator AudioSource(ImmortalAudioSource i) => i.AudioSource;
}