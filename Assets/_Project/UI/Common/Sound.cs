using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Sound", menuName = "Sound")]
public class Sound : ScriptableObject
{
    [SerializeField] private AudioClip _clip;

    public void Play(AudioSource audioSource)
    {
        audioSource.PlayOneShot(_clip);
    }
}
